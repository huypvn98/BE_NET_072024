using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAcceess_NetFrameWork.DO.Enum
{
    public class Option
    {
        public enum CHAR
        {
            Y = 1,
            N = 0
        }

        public enum NUMBER
        {
            SUM_TWO_NUMBER = 1,
            MULTIPLY_TWO_NUMBER = 2,
            SUBTRACT_TWO_NUMBER = 3,
            SOLVE_LINEAR_EQUATION = 4,
            SOLVE_QUADRATIC_EQUATION = 5,
            CONVERT_C_TO_K = 6,
            CONVERT_C_TO_F = 7,
            FACTORIAL = 8,
            LIST_PRIME_NUMBER = 9,
            CHECK_EVEN_OR_ODD = 10,
            PRINT_ARRAY_ODD_NUMBER = 11,
            PRINT_ARRAY_EVEN_NUMBER = 12,
            SORT_ARRAY_ASCENDING = 13,
            SORT_ARRAY_DESCENDING = 14,
            DISPLAY_NUMBER_IN_WORDS = 15,
            CALCULATE_FRACTION = 16,
            STATISTICS_STUDY = 17
        }
    }
    
}
