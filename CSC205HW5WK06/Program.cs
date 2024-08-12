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
            // Arrays
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };  // Need to be of the same type
            string[] friends = new string[5];  // How many array it can hold
            friends[0] = "Jim";
            friends[1] = "Kelley";
            friends[2] = "Tom";

            Console.WriteLine(luckyNumbers[1]);

            Console.ReadLine();
        }
    }
}
