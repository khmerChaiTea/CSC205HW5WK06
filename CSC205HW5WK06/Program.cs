using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC205HW5WK06
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Return Statement
            Console.WriteLine(cube(5));

            Console.ReadLine();
        }

        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }
    }
}
