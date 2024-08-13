using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC205HW5WK06
{
    public class Book
    {
        // Class attributes
        public string title;
        public string author;
        public int pages;

        public Book(string aTitle,string aAuthor,int aPages)   // Constructors a special method to call the class
        {
            title = aTitle; // Similar to book1.title
            author = aAuthor;
            pages = aPages;
        }
    }
}
