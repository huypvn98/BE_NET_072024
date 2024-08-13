using BE072024.Common_NetFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAccess_NetFrameWork.Business
{
    public class GeometryBusiness
    {

        public bool CheckValidInput(string input, string name, out string errMsg, out double value)
        {
            try
            {
                if (!ValidateData.CheckNull_Data(input))
                {
                    errMsg = string.Format("{0} không thể trống.", name);
                    value = 0;
                    return false;
                }
                if (!ValidateData.IsDouble(input, out value))
                {
                    errMsg = string.Format("{0} phải là số.", name);
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
