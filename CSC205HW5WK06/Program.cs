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
            // Inheritance
            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeChicken();
            italianChef.MakeSalad();
            italianChef.MakeSpecialDish();
            italianChef.MakePasta();    // Only the subclass can call MakePasta()

            Console.WriteLine();

            // Chef the "Super class"
            Chef chef = new Chef();
            chef.MakeChicken();
            chef.MakeSalad();
            chef.MakeSpecialDish();

            Console.ReadLine();
        }
    }
}
