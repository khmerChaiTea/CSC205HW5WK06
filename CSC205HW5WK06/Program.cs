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
            // Getters & Setters
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "dog");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            // G, PG, PG-13, R, NR

            Console.WriteLine(avengers.title);
            Console.WriteLine(avengers.director);
            Console.WriteLine(avengers.Rating);

            Console.WriteLine();

            Console.WriteLine(shrek.title);
            Console.WriteLine(shrek.director);
            Console.WriteLine(shrek.Rating);

            Console.ReadLine();
        }
    }
}
