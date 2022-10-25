using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Struct_enum_Extentions_HW_.Helpers
{
    public static class Extentions
    {
        public static double GetFactorial(this int a)
        {
            double sum = 1;

            for (int i = 1; i <= a; i++)
            {
                sum *= i;
            }
            return sum;
        }
    }
}
