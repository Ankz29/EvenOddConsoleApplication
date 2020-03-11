using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvenOddConsoleApplication;

namespace EvenOddConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write( "Enter the value to check for even and odd value: " );
            var Number = Convert.ToInt32(Console.ReadLine());

            var EvenOdd = EvenOddUtility.EvenOddMethod( Number );
            Console.Write( EvenOdd );
            Console.ReadLine();
        }
    }
}
