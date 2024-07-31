using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAccess_NetFrameWork.DO
{
    public struct Employee
    {
        public string EmpCode { get; set; }
        public string EmpName { get; set; }
        //Ngày vào làm
        public DateTime EmpStartDate { get; set; }
        //Vị trí
        public string EmpPosition { get; set; }
        //Hệ số lương
        public string EmpFactor { get; set; }

        public Employee(string empCode, string empName, DateTime empStartDate, string empPosition, string empFactor)
        {
            EmpCode = empCode;
            EmpName = empName;
            EmpStartDate = empStartDate;
            EmpPosition = empPosition;
            EmpFactor = empFactor;
        }
    }
}
