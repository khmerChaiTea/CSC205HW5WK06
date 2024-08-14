using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC205HW5WK06
{
    public class ItalianChef : Chef
    {
        // Inheritance
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes chicken parm");
        }

        public void MakePasta()
        {
            Console.WriteLine("The Chef makes pasta");
        }
    }
}
