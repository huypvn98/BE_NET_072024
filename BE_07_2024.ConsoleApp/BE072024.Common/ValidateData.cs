using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.Common_NetFrameWork.Common
{
    public static class ValidateData
    {
        public static bool CheckNullAndGreaterThanZero_Data(string input, int number)
        {
            return int.TryParse(input, out number) && number >= 0;
        }
        //tạo hàm validate mẫu số khác 0
        public static bool CheckMauSoKhacKhong(string input, int number)
        {
            return int.TryParse(input, out number) && number != 0;
        }
    }
}
