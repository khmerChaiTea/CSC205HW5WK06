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
            // Getting User Input
            Console.WriteLine("Hello"); // Next output go to a new line
            Console.Write("Enter your name: ");    // Next output stay on the same line
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you are " + age);

            Console.ReadLine();
        }
    }
}
