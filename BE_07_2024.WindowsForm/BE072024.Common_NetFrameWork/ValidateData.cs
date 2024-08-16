using System;
using System.Globalization;
using System.Linq;

namespace BE072024.Common_NetFrameWork
{
    public static class ValidateData
    {
        public static bool CheckNull_Data(string input)
        {
            return string.IsNullOrEmpty(input) ? false : true;
        }

        public static bool IsNumberic(string input, string name, out string errMsg, out int value)
        {
            if (!ValidateData.CheckNull_Data(input))
            {
                errMsg = string.Format("{0} không thể trống.", name);
                value = 0;
                return false;
            }
            if (!int.TryParse(input, out value))
            {
                errMsg = string.Format("{0} phải là số nguyên.", name);
                return false;
            }
            errMsg = string.Empty;
            return true;
        }
        public static bool IsDouble(string input, out double n)
        {
            bool isNumeric = double.TryParse(input, out n);
            return isNumeric;
        }
        public static bool IsValidName(string input)
        {
            if (input.Any(char.IsDigit))
            {
                return false;
            }
            if(input.Any(ch => !char.IsLetter(ch) && !char.IsWhiteSpace(ch)))
            {
                return false;
            }    
            return true;
        }

        public static bool CheckValidDateTime(string input)
        {

            DateTime dateValue;
            if (!DateTime.TryParseExact(input, "dd/MM/yyyy", new CultureInfo("en-US"), DateTimeStyles.None, out dateValue))
            {
                return false;

            }

            return true;
        }
    }
}
