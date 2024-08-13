using BE072024.Common_NetFrameWork;
using BE072024.DataAccess_NetFrameWork.Business;
using BE072024.DataAccess_NetFrameWork.DO.Enum;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BE_07.WindowsForm
{
    public partial class frmMain2 : Form
    {
        //List<Employee> Employees = new List<Employee>();
        ContextMenu _contextMenu;
        InvoiceBusiness invoiceBussiness = new InvoiceBusiness();
        public frmMain2()
        {
            InitializeComponent();
            InitContextMenu();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnImportInvoice_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                var rs = invoiceBussiness.NhapTuExcelFile(fileDialog.FileName);
                if (rs.Code == (int)ErrorCode.THANH_CONG)
                {
                    dtgvInvoiceList.DataSource = invoiceBussiness.Invoices;
                }
                MessageBox.Show(string.Format("Kết quả: \n{0}", rs.Msg));

            }
        }

        private void btnExportEmp5_Click(object sender, EventArgs e)
        {
            try
            {
                //using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                //{
                //    saveFileDialog.Filter = "Excel Workbook|*.xlsx";
                //    saveFileDialog.Title = "Save an Excel File";

                //    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                //    {
                //        using (XLWorkbook workbook = new XLWorkbook())
                //        {
                //            new Bai4_Bussiness().AddDataExcel(workbook, Employees, 5);

                //            // Lưu tệp Excel với đường dẫn được chọn bởi người dùng
                //            string filePath = saveFileDialog.FileName;
                //            workbook.SaveAs(filePath);

                //        }
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }

        }

        private void dtgvInvoiceList_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    if(dtgvInvoiceList.SelectedCells.Count > 0)
                    {
                        _contextMenu?.Show(dtgvInvoiceList, new Point(e.X, e.Y));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void InitContextMenu()
        {
            if (_contextMenu == null)
            {
                MenuItem phoneSelection = new MenuItem("Gọi điện", MenuItem_Click);
                MenuItem mailSelection = new MenuItem("Gửi mail", MenuItem_Click);
                MenuItem directSelection = new MenuItem("Gặp trực tiếp khách hàng", MenuItem_Click);

                _contextMenu = new ContextMenu();
                _contextMenu.MenuItems.Add(phoneSelection);
                _contextMenu.MenuItems.Add(mailSelection);
                _contextMenu.MenuItems.Add(directSelection);
            }
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Get row from selected cell
                var menuItem = (MenuItem)sender;    
                var selectedRow = dtgvInvoiceList.SelectedCells[0].OwningRow;                
                if(!string.IsNullOrEmpty(selectedRow.Cells["InteractMethod"].Value?.ToString()))
                {
                    MessageBox.Show("Khách hàng đã được tư vấn");
                    return;
                }    
                switch(menuItem.Index)
                {
                    case (int)InteractiveMethod.PHONE:
                        selectedRow.Cells["InteractMethod"].Value = "Gọi điện"; 
                        //Call phone
                        break;
                    case (int)InteractiveMethod.EMAIL:
                        selectedRow.Cells["InteractMethod"].Value = "Gửi mail";
                        //Call phone
                        break;
                    default:
                        selectedRow.Cells["InteractMethod"].Value = "Gặp trực tiếp khách hàng";
                        break;
                }
                selectedRow.Cells["InteractiveTime"].Value = DateTime.Now;
                //Lấy ra IP hiện tại của máy                
                selectedRow.Cells["IPUser"].Value = UserHelper.GetLocalIPAddress();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }


        private void btnExportByWeek_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Workbook|*.xlsx";
                    saveFileDialog.Title = "Save an Excel File";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            //new InvoiceBusiness().DataExport(workbook, invoiceBussiness.Invoices, 10);

                            // Lưu tệp Excel với đường dẫn được chọn bởi người dùng
                            string filePath = saveFileDialog.FileName;
                            workbook.SaveAs(filePath);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
