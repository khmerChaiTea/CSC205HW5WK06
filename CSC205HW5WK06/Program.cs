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
            // Static Class Attributes
            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.songCount);  // Belong to the class -- attribute about the class not the specific object
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(Song.songCount);

            Console.WriteLine(kashmir.getSongCount());

            Console.WriteLine(holiday.title);
            Console.WriteLine(holiday.artist);
            Console.WriteLine(holiday.duration);

            Console.WriteLine(kashmir.title);
            Console.WriteLine(kashmir.artist);
            Console.WriteLine(kashmir.duration);

            Console.ReadLine();
        }
    }
}
