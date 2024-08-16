using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

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

        public static bool IsValidName(string name, string fieldName, out string errorMessage)
        {
            errorMessage = string.Empty;
            if(!IsValidText(name, fieldName, out errorMessage))
            {
                return true;
            }
            if (Regex.IsMatch(name, @"\d"))
            {
                errorMessage = $"{fieldName} không chứa ký tự số. Vui lòng nhập lại";
                return false;
            }
            return true;
        }

        public static bool IsInt(string input, string fieldName, out string errorMessage, out int n)
        {
            errorMessage = string.Empty;
            if (!int.TryParse(input, out n))
            {
                errorMessage = $"{fieldName} phải là số nguyên. Vui lòng nhập lại";
                return false;
            }
            return true;
        }

        public static bool IsIntAndGreaterThanZero(string text, string fieldName, out string errorMessage, out int n)
        {
            errorMessage = string.Empty;
            if (!int.TryParse(text, out n))
            {
                errorMessage = $"{fieldName} phải là số nguyên. Vui lòng nhập lại";
                return false;
            }
            if(n <= 0)
            {
                errorMessage = $"{fieldName} phải lớn hơn 0. Vui lòng nhập lại";
                return false;
            }
            return true;
        }

        public static bool IsValidText(string text, string fieldName, out string errorMessage)
        {
            errorMessage = string.Empty;
            if (string.IsNullOrEmpty(text))
            {
                errorMessage = $"{fieldName} không được để trống. Vui lòng nhập lại";
                return false;
            }
            return true;
        }

        public static bool IsDouble(string text, string fieldName, out string errorMessage, out double n)
        {
            errorMessage = string.Empty;
            if (!double.TryParse(text, out n))
            {
                errorMessage = $"{fieldName} phải là số. Vui lòng nhập lại.";
                return false;
            }
            return true;
        }
        public static bool IsDoubleAndGreaterThanZero(string text, string fieldName, out string errorMessage, out double n)
        {
            errorMessage = string.Empty;
            if (!IsDouble(text, fieldName, out errorMessage, out n))
            {
                errorMessage = $"{fieldName} phải là số nguyên. Vui lòng nhập lại";
                return false;
            }
            if (n <= 0)
            {
                errorMessage = $"{fieldName} phải lớn hơn 0. Vui lòng nhập lại";
                return false;
            }
            return true;
        }
    }
}
