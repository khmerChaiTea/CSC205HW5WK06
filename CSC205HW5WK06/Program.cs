using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC205HW5WK06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Working with numbers
            int num = 6;
            Console.WriteLine(4 + 2 * 3);
            Console.WriteLine((4 + 2) * 3);
            Console.WriteLine(5.0 + 8.1);   // Get a decimal
            Console.WriteLine(5 + 8.1);     // Get a decimal
            Console.WriteLine(5 / 2);       // Get an integer
            Console.WriteLine(num);
            num++;
            Console.WriteLine(num);
            ++num;
            Console.WriteLine(num);
            num--;
            Console.WriteLine(num);
            --num;
            Console.WriteLine(num);

            // Methods
            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Pow(3,2));
            Console.WriteLine(Math.Sqrt(9));
            Console.WriteLine(Math.Max(4, 90));
            Console.WriteLine(Math.Min(4, 90));
            Console.WriteLine(Math.Round(4.6));

            Console.ReadLine();
        }
    }
}
