using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC205HW5WK06
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Static Methods & Classes
            //Math maths = new Math();  // Class is static -- error
            Console.WriteLine(Math.Sqrt(144));  // An example of static method

            UsefulTools tools = new UsefulTools();  // Class is not static
            UsefulTools.SayHi("Prem");

            Console.ReadLine();
        }
    }
}
