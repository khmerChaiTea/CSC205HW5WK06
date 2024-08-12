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
            // Building a Calculator
            int num = Convert.ToInt32("45");    // Convert string into an integer -- only work with number only
            //int num = Convert.ToInt32("56sadf");  // Will not work because is not number only
            Console.WriteLine("43" + "56"); // Concatenate - output ast string 4356
            Console.WriteLine(num + 6);

            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine()); // Change int into double and convert ToDouble for decimal input
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);

            Console.ReadLine();
        }
    }
}
