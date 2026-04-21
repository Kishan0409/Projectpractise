using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectpractise
{
    internal class SI
    {
        float p, r, t, si;
        internal void calsi()
        {
            p = 12000;
            r = 4.5f;
            t = 2;
            si = (p * r * t) / 100;
         Console.WriteLine("Simple Interest is: " + si);

        }

    }
}
