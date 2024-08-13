using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAccess_NetFrameWork.DO
{
    public struct Invoice
    {
        public string InvoiceCode { get; set; }
        public string CustomerCode { get; set; }
        //Ngày xuất hóa đơn
        public DateTime InvoiceDate { get; set; }
        //Tổng tiền
        public int TotalAmount { get; set; }
        //Tổng nợ
        public int TotalDebt { get; set; }
        public string InteractiveMethod { get; set; }
        public DateTime InteractiveTime { get; set; }
        public string IpUser { get; set; }

        public Invoice(string invoiceCode, string customerCode, DateTime invoiceDate, int totalAmount, int totalDebt, string interactiveMethod, DateTime interactiveTime, string ipUser)
        {
            InvoiceCode = invoiceCode;
            CustomerCode = customerCode;
            InvoiceDate = invoiceDate;
            TotalAmount = totalAmount;
            TotalDebt = totalDebt;
            InteractiveMethod = interactiveMethod;
            InteractiveTime = interactiveTime;
            IpUser = ipUser;
        }
    }
}
