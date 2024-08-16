using BE072024.Common_NetFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAccess_NetFrameWork.Business
{
    public class EmployeeBusiness
    {
        public bool CheckValidName(string input, string name, out string errMsg)
        {
            try
            {
                if (!ValidateData.CheckNull_Data(input))
                {
                    errMsg = string.Format("{0} không thể trống.", name);
                    return false;
                }
                if (!ValidateData.IsValidName(input))
                {
                    errMsg = string.Format("{0} không được chứa số và ký tự đặc biệt.", name);
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

        public bool CheckValidNumber(string input, string name, out string errMsg, out double value)
        {
            try
            {
                if (!ValidateData.CheckNull_Data(input))
                {
                    errMsg = string.Format("{0} không thể trống.", name);
                    value = 0;
                    return false;
                }
                if (!ValidateData.IsValidName(input))
                {
                    errMsg = string.Format("{0} không được chứa số và ký tự đặc biệt.", name);
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
