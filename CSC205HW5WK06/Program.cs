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
            // For Loops
            //int i = 1;
            //while (i <= 5 )
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            
            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }

            Console.ReadLine();
        }
    }
}
