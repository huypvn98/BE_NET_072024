using System.Drawing;
using System.Windows.Forms;

namespace BE_07.WindowsForm
{
    partial class frmMain2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnImportInvoice = new System.Windows.Forms.Button();
            this.btnExportByWeek = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnExportByMonth = new System.Windows.Forms.Button();
            this.dtgvInvoiceList = new System.Windows.Forms.DataGridView();
            this.InvoiceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDebt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InteractMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InteractiveTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IPUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInvoiceList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImportInvoice
            // 
            this.btnImportInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportInvoice.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportInvoice.ForeColor = System.Drawing.Color.Green;
            this.btnImportInvoice.Location = new System.Drawing.Point(0, 5);
            this.btnImportInvoice.Name = "btnImportInvoice";
            this.btnImportInvoice.Size = new System.Drawing.Size(523, 26);
            this.btnImportInvoice.TabIndex = 1;
            this.btnImportInvoice.Text = "Imprort hóa đơn";
            this.btnImportInvoice.UseVisualStyleBackColor = true;
            this.btnImportInvoice.Click += new System.EventHandler(this.btnImportInvoice_Click);
            // 
            // btnExportByWeek
            // 
            this.btnExportByWeek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportByWeek.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportByWeek.ForeColor = System.Drawing.Color.Green;
            this.btnExportByWeek.Location = new System.Drawing.Point(0, 36);
            this.btnExportByWeek.Name = "btnExportByWeek";
            this.btnExportByWeek.Size = new System.Drawing.Size(523, 25);
            this.btnExportByWeek.TabIndex = 3;
            this.btnExportByWeek.Text = "Xuất excel danh sách lịch sử tương tác với hóa đơn của các nhân viên theo tuần";
            this.btnExportByWeek.UseVisualStyleBackColor = true;
            this.btnExportByWeek.Click += new System.EventHandler(this.btnExportByWeek_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnExportByMonth);
            this.pnlMenu.Controls.Add(this.btnImportInvoice);
            this.pnlMenu.Controls.Add(this.btnExportByWeek);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(525, 97);
            this.pnlMenu.TabIndex = 4;
            // 
            // btnExportByMonth
            // 
            this.btnExportByMonth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportByMonth.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportByMonth.ForeColor = System.Drawing.Color.Green;
            this.btnExportByMonth.Location = new System.Drawing.Point(0, 67);
            this.btnExportByMonth.Name = "btnExportByMonth";
            this.btnExportByMonth.Size = new System.Drawing.Size(523, 25);
            this.btnExportByMonth.TabIndex = 4;
            this.btnExportByMonth.Text = "Xuất excel danh sách lịch sử tương tác với hóa đơn của các nhân viên theo tháng";
            this.btnExportByMonth.UseVisualStyleBackColor = true;
            // 
            // dtgvInvoiceList
            // 
            this.dtgvInvoiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvInvoiceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceCode,
            this.CustomerCode,
            this.InvoiceDate,
            this.TotalAmount,
            this.TotalDebt,
            this.InteractMethod,
            this.InteractiveTime,
            this.IPUser});
            this.dtgvInvoiceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvInvoiceList.Location = new System.Drawing.Point(0, 97);
            this.dtgvInvoiceList.Name = "dtgvInvoiceList";
            this.dtgvInvoiceList.Size = new System.Drawing.Size(525, 257);
            this.dtgvInvoiceList.TabIndex = 5;
            this.dtgvInvoiceList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgvInvoiceList_MouseClick);
            // 
            // InvoiceCode
            // 
            this.InvoiceCode.DataPropertyName = "InvoiceCode";
            this.InvoiceCode.HeaderText = "Mã hóa đơn";
            this.InvoiceCode.Name = "InvoiceCode";
            this.InvoiceCode.Width = 90;
            // 
            // CustomerCode
            // 
            this.CustomerCode.DataPropertyName = "CustomerCode";
            this.CustomerCode.HeaderText = "Mã khách hàng";
            this.CustomerCode.Name = "CustomerCode";
            this.CustomerCode.Width = 110;
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.DataPropertyName = "InvoiceDate";
            this.InvoiceDate.HeaderText = "Ngày xuất hóa đơn";
            this.InvoiceDate.Name = "InvoiceDate";
            this.InvoiceDate.Width = 125;
            // 
            // TotalAmount
            // 
            this.TotalAmount.DataPropertyName = "TotalAmount";
            this.TotalAmount.HeaderText = "Tổng tiền";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Width = 75;
            // 
            // TotalDebt
            // 
            this.TotalDebt.DataPropertyName = "TotalDebt";
            this.TotalDebt.HeaderText = "Tổng tiền nợ";
            this.TotalDebt.Name = "TotalDebt";
            this.TotalDebt.Width = 90;
            // 
            // InteractMethod
            // 
            this.InteractMethod.DataPropertyName = "InteractMethod";
            this.InteractMethod.HeaderText = "Hình thức";
            this.InteractMethod.Name = "InteractMethod";
            this.InteractMethod.Visible = false;
            // 
            // InteractiveTime
            // 
            this.InteractiveTime.DataPropertyName = "InteractiveTime";
            this.InteractiveTime.HeaderText = "Thời gian tương tác";
            this.InteractiveTime.Name = "InteractiveTime";
            this.InteractiveTime.Visible = false;
            // 
            // IPUser
            // 
            this.IPUser.DataPropertyName = "IPUser";
            this.IPUser.HeaderText = "Người dùng";
            this.IPUser.Name = "IPUser";
            this.IPUser.Visible = false;
            // 
            // frmMain2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 354);
            this.Controls.Add(this.dtgvInvoiceList);
            this.Controls.Add(this.pnlMenu);
            this.Name = "frmMain2";
            this.Text = "Quản lý nhân sự";
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInvoiceList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnImportInvoice;
        private Button btnExportByWeek;
        private Panel pnlMenu;
        private DataGridView dtgvInvoiceList;
        private Button btnExportByMonth;
        private DataGridViewTextBoxColumn InvoiceCode;
        private DataGridViewTextBoxColumn CustomerCode;
        private DataGridViewTextBoxColumn InvoiceDate;
        private DataGridViewTextBoxColumn TotalAmount;
        private DataGridViewTextBoxColumn TotalDebt;
        private DataGridViewTextBoxColumn InteractMethod;
        private DataGridViewTextBoxColumn InteractiveTime;
        private DataGridViewTextBoxColumn IPUser;
    }
}

