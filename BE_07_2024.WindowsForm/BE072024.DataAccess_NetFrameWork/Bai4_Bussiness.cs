using BE072024.DataAccess_NetFrameWork.DO;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAccess_NetFrameWork
{
    public class Bai4_Bussiness
    {
        public void AddDataExcel(XLWorkbook workbook, List<Employee> Employees, int yearNum)
        {       
            var worksheet = workbook.Worksheets.Add("Sheet1");

            // Thêm tiêu đề cho các cột
            worksheet.Cell(1, 1).Value = "Mã nhân viên";
            worksheet.Cell(1, 2).Value = "Tên nhân viên";
            worksheet.Cell(1, 3).Value = "Ngày vào công ty";
            worksheet.Cell(1, 4).Value = "Chức vụ";
            worksheet.Cell(1, 5).Value = "Hệ số";

            var employees = Employees.FindAll(c => c.EmpStartDate.Year == DateTime.Now.Year - yearNum);
            // Thêm dữ liệu vào các hàng
            for (int i = 0; i < employees.Count; i++)
            {
                worksheet.Cell(i + 2, 1).Value = employees[i].EmpCode;
                worksheet.Cell(i + 2, 2).Value = employees[i].EmpName;
                worksheet.Cell(i + 2, 3).Value = employees[i].EmpStartDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                worksheet.Cell(i + 2, 4).Value = employees[i].EmpPosition;
                worksheet.Cell(i + 2, 5).Value = employees[i].EmpFactor;
            }
            // Điều chỉnh độ rộng cột tự động
            worksheet.Columns().AdjustToContents();
        }
    }
}
