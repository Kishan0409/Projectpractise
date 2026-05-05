using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1)  WAP to check leap year using ternary operator?

namespace Projectpractise
{
    internal class LeapYear
    {
        internal void pLeapYear()
        {
            int year = 3000;
            string output = year % 400 == 0 || (year % 4 == 0 && year % 100!= 0) ? "leap Year" : "Not a leap year ";

            Console.WriteLine(output);
        }

    }
}
