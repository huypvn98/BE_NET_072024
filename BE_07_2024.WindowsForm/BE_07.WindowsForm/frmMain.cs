using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Windows.Forms;
using OpenQA.Selenium.Interactions;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using Microsoft.VisualBasic.ApplicationServices;
using MySqlConnector;
using BE072024.DataAccess_NetFrameWork.DO;
using OfficeOpenXml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ClosedXML.Excel;
using System.Globalization;
using BE072024.DataAccess_NetFrameWork;

namespace AutoChangeOrderOracle
{
    public partial class FrmMain : Form
    {
        public List<Employee> Employees = new List<Employee>();
        public FrmMain()
        {
            InitializeComponent();


        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            frmAddEmp frmAddEmp = new frmAddEmp(Employees);
            frmAddEmp.ShowDialog();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShowEmpLst_Click(object sender, EventArgs e)
        {
            frmEmpLst frmEmpLst = new frmEmpLst(Employees);
            frmEmpLst.ShowDialog();
        }

        private void btnImportEmp_Click(object sender, EventArgs e)
        {
            string pathexcel = "";
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pathexcel = fileDialog.FileName;
            }

            try
            {
                var pakage = new ExcelPackage(new FileInfo(pathexcel));
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                ExcelWorksheet worksheet = pakage.Workbook.Worksheets[0];
                for (int ex = worksheet.Dimension.Start.Row + 1; ex <= worksheet.Dimension.End.Row; ex++)
                {
                    try
                    {
                        int j = 1;
                        Employees.Add(new Employee
                        {
                            EmpCode = worksheet.Cells[ex, j++].Value.ToString(),
                            EmpName = worksheet.Cells[ex, j++].Value.ToString(),
                            EmpStartDate = DateTime.ParseExact(worksheet.Cells[ex, j++].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture),
                            EmpPosition = worksheet.Cells[ex, j++].Value.ToString(),
                            EmpFactor = worksheet.Cells[ex, j++].Value.ToString()
                        });
                    }
                    catch
                    {

                    }
                }

            }
            catch
            {

            }
        }

        private void btnExportEmp5_Click(object sender, EventArgs e)
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
                            new Bai4_Bussiness().AddDataExcel(workbook, Employees, 5);                            

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

        private void btnExportEmp10_Click(object sender, EventArgs e)
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
                            new Bai4_Bussiness().AddDataExcel(workbook, Employees, 10);

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
