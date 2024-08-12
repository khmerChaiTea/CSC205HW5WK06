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
            // Working with string
            string phrase = "FreeCodeCamp Academy";
            Console.WriteLine(phrase[13]);   // Put the index of the string, start with 0
            Console.WriteLine(phrase.IndexOf("Academy"));   // Give the starting index of the word
            Console.WriteLine(phrase.IndexOf('z')); // Output -1 because it is not existed
            Console.WriteLine(phrase.Substring(13));
            Console.WriteLine(phrase.Substring(13, 3));    // Gab only three characters

            Console.ReadLine();
        }
    }
}
