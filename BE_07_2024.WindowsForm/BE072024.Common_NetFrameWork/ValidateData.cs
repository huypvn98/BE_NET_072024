using System;
using System.Globalization;

namespace BE072024.Common_NetFrameWork
{
    public static class ValidateData
    {
        public static bool CheckNull_Data(string input)
        {
            return string.IsNullOrEmpty(input) ? false : true;
        }

        public static bool IsNumberic(string input)
        {
            int n;
            bool isNumeric = int.TryParse(input, out n);
            return isNumeric;
        }
        public static bool IsDouble(string input, out double n)
        {
            bool isNumeric = double.TryParse(input, out n);
            return isNumeric;
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
