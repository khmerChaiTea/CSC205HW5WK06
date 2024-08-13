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
            // Classes & Objects
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;  // Instance of the book class

            Book book2 = new Book();
            book2.title = "Lord of the Rings";
            book2.author = "Tolkein";
            book2.pages = 700;  // Instance of the book class

            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.pages);

            Console.WriteLine();

            Console.WriteLine(book2.title);
            Console.WriteLine(book2.author);
            Console.WriteLine(book2.pages);

            Console.ReadLine();
        }
    }
}
