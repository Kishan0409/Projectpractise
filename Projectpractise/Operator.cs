using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Wap Program to check that entered number is an even number or an odd number?   
namespace Projectpractise
{
    internal class Operator
    {
        public void main()
        {
            int num = 6;
            string output = (num % 2 == 0) ? "even no." : "this no, is odd";
            Console.WriteLine(output);
        }

    }
}
