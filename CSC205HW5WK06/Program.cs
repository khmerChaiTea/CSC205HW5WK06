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
            // 2d Arrays
            int[,] numberGrid = {
                { 1, 2 },
                { 3, 4 },
                { 5, 6 }
            };
            int[,] myArray = new int[2, 3];

            Console.WriteLine(numberGrid[1,1]);
            Console.WriteLine(numberGrid[2, 1]);

            Console.ReadLine();
        }
    }
}
