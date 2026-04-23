using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// WAP TO CALCULATE THE SUM OF DIGITS OF A GIVEN DATE. (EXAMPLE: 12/05/2020, SUM OF DIGITS = 1+2+0+5+2+0+2+0=12)

namespace Projectpractise
{
    internal class SumDateDigit
    {
        public void SumDDigit()
        {
            string date1 = "12052016";
            int d1 = Convert.ToInt32(date1);
            int sum = 0;
            while(d1!= 0)
            {
                int first = d1 % 10;
                d1 = (int)(d1 / 10);
                sum += first;

            }
            Console.WriteLine(sum);




        }


    }
}
