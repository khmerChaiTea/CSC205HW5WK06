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
            // If Statement (con't)
            Console.WriteLine(GetMax(20, 10, 40));

            Console.ReadLine();
        }

        static int GetMax(int num1, int num2, int num3)
        {
            int result;
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && (num2 >= num3))
            {
                result = num2;
            }
            else
            {
                result = num3;
            }

            return result;
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
