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
            // If Statement
            bool isMale = false;
            bool isTall = false;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are not a male but you are tall");
            }
            else
            {
                Console.WriteLine("You are not male and not tall");
            }

            Console.ReadLine();
        }
    }
}
///sumary///
/// I wake up
/// If I'm hungry
///     I eat breakfast
///     
/// I look at my phone
/// if it's about to die
///     I charge it
///     
/// I leave my house
/// if it;s cloudy
///     i bring an unbrella
/// otherwise
///     I bring sunglasses
