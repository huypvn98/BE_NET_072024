IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'CUSTOMER')
BEGIN
CREATE TABLE CUSTOMER (
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    CustomerName NVARCHAR(100),
    ContactNumber VARCHAR(15),
    Email NVARCHAR(100),
    Address NVARCHAR(255)
);
END
GO
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'PRODUCT')
BEGIN
CREATE TABLE PRODUCT (
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    ProductName NVARCHAR(100),
    UnitPrice DECIMAL(10, 2),
    StockQuantity INT
);
END
GO
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'ORDER')
BEGIN
CREATE TABLE [ORDER] (
    OrderID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT,
    OrderDate DATE,
    TotalAmount DECIMAL(10, 2),
    FOREIGN KEY (CustomerID) REFERENCES CUSTOMER(CustomerID)
);
END
GO
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'ORDER_DETAIL')
BEGIN 
CREATE TABLE ORDER_DETAIL (
    OrderDetailID INT PRIMARY KEY IDENTITY(1,1),
    OrderID INT,
    ProductID INT,
    Quantity INT,
    UnitPrice DECIMAL(10, 2),
    FOREIGN KEY (OrderID) REFERENCES [ORDER](OrderID),
    FOREIGN KEY (ProductID) REFERENCES PRODUCT(ProductID)
);
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AddCustomer]') AND type IN (N'P', N'PC'))
BEGIN 
    EXEC('CREATE PROCEDURE AddCustomer
    @CustomerName NVARCHAR(100),
    @ContactNumber NVARCHAR(15),
    @Email NVARCHAR(100),
    @Address NVARCHAR(255)
AS
    BEGIN
    -- Kiểm tra sự tồn tại của ContactNumber hoặc Email
    IF EXISTS (SELECT 1 FROM CUSTOMER WHERE ContactNumber = @ContactNumber OR Email = @Email)
        BEGIN
        -- Nếu tồn tại, trả về thông báo lỗi
        RAISERROR (N''Khách hàng đã tồn tại.'', 16, 1);
            RETURN;
        END
        -- Nếu không tồn tại, thêm khách hàng mới
        INSERT INTO CUSTOMER (CustomerName, ContactNumber, Email, Address)
        VALUES (@CustomerName, @ContactNumber, @Email, @Address);
    END');
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AddProduct]') AND type IN (N'P', N'PC'))
BEGIN
    EXEC('CREATE PROCEDURE AddProduct
    @ProductName NVARCHAR(100),
    @UnitPrice DECIMAL(10, 2),
    @StockQuantity INT
AS
BEGIN
   -- Kiểm tra sự tồn tại của ProductName
    IF EXISTS (SELECT 1 FROM PRODUCT WHERE ProductName = @ProductName)
    BEGIN
        -- Nếu tồn tại, trả về thông báo lỗi
        ;THROW 50000, N''Sản phẩm đã tồn tại.'', 1;
    END
    ELSE
    BEGIN
        -- Nếu không tồn tại, thêm sản phẩm mới
        INSERT INTO PRODUCT (ProductName, UnitPrice, StockQuantity)
        VALUES (@ProductName, @UnitPrice, @StockQuantity);
    END
END');
END
GO
IF NOT EXISTS (SELECT * FROM sys.types WHERE is_table_type = 1 AND name = N'ORDER_DETAIL_TYPE')
BEGIN
    CREATE TYPE ORDER_DETAIL_TYPE AS TABLE
    (
        ProductID INT,
        Quantity INT,
        UnitPrice DECIMAL(18, 2)
    );
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CreateOrder]') AND type IN (N'P', N'PC'))
BEGIN
    EXEC('
        CREATE PROCEDURE CreateOrder
    @CustomerID INT,
    @OrderDate DATETIME,
    @OrderDetails ORDER_DETAIL_TYPE READONLY -- Sử dụng bảng tạm để truyền chi tiết đơn hàng
AS
BEGIN
    BEGIN TRANSACTION;

    DECLARE @OrderID INT;
    DECLARE @TotalAmount DECIMAL(18, 2);

    -- Kiểm tra sự tồn tại của CustomerID
    IF NOT EXISTS (SELECT 1 FROM CUSTOMER WHERE CustomerID = @CustomerID)
    BEGIN
        ROLLBACK TRANSACTION;
        RAISERROR (N''Khách hàng không tồn tại.'', 16, 1);
        RETURN;
    END

    -- Tạo bảng tạm để lưu trữ các ProductID không hợp lệ
    CREATE TABLE #InvalidProducts (ProductID INT);

    -- Kiểm tra sự tồn tại của ProductID trong ORDER_DETAIL_TYPE
    INSERT INTO #InvalidProducts (ProductID)
    SELECT od.ProductID
    FROM @OrderDetails od
    LEFT JOIN PRODUCT p ON od.ProductID = p.ProductID
    WHERE p.ProductID IS NULL;

    -- Nếu có ProductID không hợp lệ, thông báo lỗi
    IF EXISTS (SELECT 1 FROM #InvalidProducts)
    BEGIN
        DECLARE @ErrorMessage NVARCHAR(MAX);
        SELECT @ErrorMessage = STRING_AGG(CONVERT(NVARCHAR(MAX), ProductID), '', '') 
        FROM #InvalidProducts;

        ROLLBACK TRANSACTION;
        RAISERROR (N''Các sản phẩm không tồn tại: %s'', 16, 1, @ErrorMessage);
        RETURN;
    END

    -- Tính tổng tiền
    SELECT @TotalAmount = SUM(Quantity * UnitPrice) FROM @OrderDetails;

    -- Tạo đơn hàng
    INSERT INTO [ORDER] (CustomerID, OrderDate, TotalAmount)
    VALUES (@CustomerID, @OrderDate, @TotalAmount);

    SET @OrderID = SCOPE_IDENTITY();

    -- Thêm chi tiết đơn hàng
    INSERT INTO ORDER_DETAIL (OrderID, ProductID, Quantity, UnitPrice)
    SELECT @OrderID, ProductID, Quantity, UnitPrice FROM @OrderDetails;

    -- Cập nhật số lượng tồn kho
    UPDATE PRODUCT
    SET StockQuantity = StockQuantity - od.Quantity
    FROM PRODUCT p
    JOIN @OrderDetails od ON p.ProductID = od.ProductID
    WHERE p.StockQuantity >= od.Quantity;

    IF @@ROWCOUNT = 0
    BEGIN
        ROLLBACK TRANSACTION;
        RAISERROR (N''Không đủ số lượng sản phẩm trong kho.'', 16, 1);
        RETURN;
    END

    COMMIT TRANSACTION;
END
    ');
END 
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetOrderDetails]') AND type IN (N'P', N'PC'))
BEGIN
    EXEC('CREATE PROCEDURE GetOrderDetails
    @OrderID INT
AS
BEGIN
    -- Kiểm tra sự tồn tại của OrderID
    IF NOT EXISTS (SELECT 1 FROM [ORDER] WHERE OrderID = @OrderID)
    BEGIN
        RAISERROR (N''Đơn hàng không tồn tại.'', 16, 1);
        RETURN;
    END
    SELECT o.OrderID, 
            o.OrderDate, 
            o.TotalAmount, 
            c.CustomerName, 
            c.ContactNumber, 
            c.Email, 
            c.Address,
            od.ProductID, 
            p.ProductName, 
            od.Quantity, 
            od.UnitPrice
    FROM [ORDER] o
    JOIN CUSTOMER c ON o.CustomerID = c.CustomerID
    JOIN ORDER_DETAIL od ON o.OrderID = od.OrderID
    JOIN PRODUCT p ON od.ProductID = p.ProductID
    WHERE o.OrderID = @OrderID;
END');
END 
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetOrderDetails]') AND type IN (N'P', N'PC'))
BEGIN
    EXEC('
    CREATE PROCEDURE DeleteOrder
    @OrderID INT
AS
BEGIN
    BEGIN TRANSACTION;
    -- Kiểm tra sự tồn tại của OrderID
    IF NOT EXISTS (SELECT 1 FROM [ORDER] WHERE OrderID = @OrderID)
    BEGIN
        RAISERROR (N''Đơn hàng không tồn tại.'', 16, 1);
        RETURN;
    END
    -- Xóa chi tiết đơn hàng
    DELETE FROM ORDER_DETAIL WHERE OrderID = @OrderID;

    -- Xóa đơn hàng
    DELETE FROM [ORDER] WHERE OrderID = @OrderID;

    COMMIT TRANSACTION;
    END');
END 



