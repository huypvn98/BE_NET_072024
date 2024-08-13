using BE072024.Common_NetFrameWork;
using BE072024.DataAccess_NetFrameWork.DO;
using BE072024.DataAccess_NetFrameWork.DO.Enum;
using ClosedXML.Excel;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace BE072024.DataAccess_NetFrameWork.Business
{
    public class InvoiceBusiness
    {
        public List<Invoice> Invoices = new List<Invoice>();

        public ResponseModel NhapTuExcelFile(string filePath)
        {
            ResponseModel responseModel = new ResponseModel();
            StringBuilder itemError = new StringBuilder();
            string errMsg = string.Empty;
            try
            {
                // NHẤN ALT+ ENTER 
                ExcelPackage.LicenseContext = LicenseContext.Commercial;

                using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
                {
                    //get the first worksheet in the workbook
                    ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];
                    int colCount = worksheet.Dimension.End.Column;  //get Column Count
                    int rowCount = worksheet.Dimension.End.Row;     //get row count
                    for (int row = 2; row <= rowCount; row++)
                    {
                        // row=2 ý chỉ dữ liệu bắt đầu từ dòng số 2 trong file excel
                        // LẤY DỮ LIỆU THEO HÀNG VÀ CỘT
                        var maHoaDon = worksheet.Cells[row, 1].Value?.ToString().Trim();
                        var maKhachHang = worksheet.Cells[row, 2].Value?.ToString().Trim();
                        var ngaySinh = worksheet.Cells[row, 3].Value?.ToString().Trim();
                        var tongTien = worksheet.Cells[row, 4].Value?.ToString().Trim();
                        var tongTienNo = worksheet.Cells[row, 5].Value?.ToString().Trim();

                        if (!CheckValidMa(maHoaDon, row.ToString(), worksheet.Cells[1, 1].Value.ToString(), out errMsg))
                        {
                            itemError.Append(errMsg);
                            continue;
                        }

                        if (!CheckValidMa(maKhachHang, row.ToString(), worksheet.Cells[1, 2].Value.ToString(), out errMsg))
                        {
                            itemError.Append(errMsg);
                            continue;
                        }

                        if (!CheckValidNgaySinh(ngaySinh, row.ToString(), worksheet.Cells[1, 3].Value.ToString(), out errMsg))
                        {
                            itemError.Append(errMsg);
                            continue;
                        }

                        if (!CheckValidTotalAmount(tongTien, row.ToString(), worksheet.Cells[1, 4].Value.ToString(), out errMsg))
                        {
                            itemError.Append(errMsg);
                            continue;
                        }

                        if (!CheckValidTotalDebt(tongTienNo, row.ToString(), worksheet.Cells[1, 5].Value.ToString(), out errMsg))
                        {
                            itemError.Append(errMsg);
                            continue;
                        }

                        Invoice invoice = new Invoice();
                        invoice.InvoiceCode = maHoaDon;
                        invoice.CustomerCode = maKhachHang;
                        invoice.InvoiceDate = DateTime.ParseExact(ngaySinh.Split(' ')[0], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        invoice.TotalAmount = int.Parse(tongTien);
                        invoice.TotalDebt = int.Parse(tongTienNo);
                        Invoices.Add(invoice);
                    }
                }

                if (itemError.Length > 0)
                {
                    responseModel.Code = (int)ErrorCode.THAT_BAI;
                    responseModel.Msg = itemError.ToString();
                    return responseModel;
                }
            }
            catch (Exception ex)
            {

                responseModel.Code = (int)ErrorCode.EXCEPTION;
                responseModel.Msg = ex.StackTrace;
                return responseModel;
            }

            responseModel.Code = (int)ErrorCode.THANH_CONG;
            responseModel.Msg = "Import thành công";
            return responseModel;
        }


        public void DataExport(XLWorkbook workbook
            //, DataGridView Employees
            , int yearNum)
        {
            //var worksheet = workbook.Worksheets.Add("Sheet1");

            //// Thêm tiêu đề cho các cột
            //worksheet.Cell(1, 1).Value = "Mã nhân viên";
            //worksheet.Cell(1, 2).Value = "Tên nhân viên";
            //worksheet.Cell(1, 3).Value = "Ngày vào công ty";
            //worksheet.Cell(1, 4).Value = "Chức vụ";
            //worksheet.Cell(1, 5).Value = "Hệ số";

            //var employees = Employees.FindAll(c => c.EmpStartDate.Year == DateTime.Now.Year - yearNum);
            //// Thêm dữ liệu vào các hàng
            //for (int i = 0; i < employees.Count; i++)
            //{
            //    worksheet.Cell(i + 2, 1).Value = employees[i].EmpCode;
            //    worksheet.Cell(i + 2, 2).Value = employees[i].EmpName;
            //    worksheet.Cell(i + 2, 3).Value = employees[i].EmpStartDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            //    worksheet.Cell(i + 2, 4).Value = employees[i].EmpPosition;
            //    worksheet.Cell(i + 2, 5).Value = employees[i].EmpFactor;
            //}
            // Điều chỉnh độ rộng cột tự động
            //worksheet.Columns().AdjustToContents();
        }


        private bool CheckValidMa(string ma, string row, string columnName, out string errMsg)
        {
            try
            {
                if (!ValidateData.CheckNull_Data(ma))
                {
                    errMsg = string.Format("{0} ở hàng số {1} bị trống", columnName, row);
                    return false;
                }
                errMsg = string.Empty;
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw;
            }
        }


        private bool CheckValidNgaySinh(string ngaysinh, string row, string columnName, out string errMsg)
        {
            try
            {
                if (!ValidateData.CheckNull_Data(ngaysinh))
                {
                    errMsg = string.Format("{0} ở hàng số {1} bị trống\n", columnName, row);
                    return false;
                }


                if (!ValidateData.CheckValidDateTime(ngaysinh.Split(' ')[0]))
                {
                    errMsg = string.Format("{0} ở hàng số {1} không đúng định dạng\n", columnName, row);
                    return false;
                }

                errMsg = string.Empty;
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw;
            }
        }

        private bool CheckValidTotalAmount(string tongtien, string row, string columnName, out string errMsg)
        {
            try
            {
                if (!ValidateData.CheckNull_Data(tongtien))
                {
                    errMsg = string.Format("{0} ở hàng số {1} bị trống", columnName, row);
                    return false;
                }


                if (!ValidateData.IsNumberic(tongtien))
                {
                    errMsg = string.Format("{0} ở hàng số {1} không phải là số", columnName, row);
                    return false;
                }

                errMsg = string.Empty;
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw;
            }
        }

        private bool CheckValidTotalDebt(string tongtienno, string row, string columnName, out string errMsg)
        {
            try
            {

                if (!ValidateData.IsNumberic(tongtienno))
                {
                    errMsg = string.Format("{0} ở hàng số {1} không phải là số", columnName, row);
                    return false;
                }

                errMsg = string.Empty;
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw;
            }
        }
    }
}
