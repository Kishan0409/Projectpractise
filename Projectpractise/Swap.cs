using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectpractise
{
    internal class Swap
    {
        internal void swapvariable()
        {
            int a = 10; int b = 20;
            Console.WriteLine("befor swap");
            Console.WriteLine("a = " + a + ", b=" + b);

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("after swap");
            Console.WriteLine("a = " + a + ", b=" + b);
        }





    }
}
