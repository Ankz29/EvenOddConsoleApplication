using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddConsoleApplication
{
      public static class EvenOddUtility
    {
        public static string EvenOddMethod(int value)
        {
            if(value %2 == 0)
            {
                return "Entered value is Even: "+ value;
            }
            else
            {
                return "Entered value is Odd: "+ value;
            }
        }
    }
}
