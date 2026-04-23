using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectpractise
{

    internal class CompundI
    {
        internal void ci()

        {
            double P, R, T, CI, Amount;

            Console.WriteLine("Enter the Principal Amount: ");
            P = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Rate : ");
            R = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Time( (in years)  : ");
            T = Convert.ToDouble(Console.ReadLine());

            Amount = P * Math.Pow((1 + R / 100), T);

            CI = Amount - P;

            Console.WriteLine("Compound Interest is: " + CI);
        }


    }
}