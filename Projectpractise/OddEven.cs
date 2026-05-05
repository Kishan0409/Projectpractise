
//Program to check that entered number is an even number or an odd number?
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectpractise
{
    internal class OddEven
    {

        internal void OddEvenNmuber()
        {
            
            Console.WriteLine("Enter a number");
             int num = int.Parse(Console.ReadLine());
            string s = (num % 2 == 0) ? "This number is even no." : "This number is odd number";
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
