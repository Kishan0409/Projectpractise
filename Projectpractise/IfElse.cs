using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Q1. WAP to calculate square if number is Even otherWise calculate cube ??
//namespace Projectpractise
//{
//    internal class IfElse
//    {
//        internal void IiFElse()
//        {
//            int num = 4;
//            int result; 
//            if(num%2==0) {
//                 result = num* num;

//            Console.WriteLine("Square is " + result);
//                }
//            else
//            {

//                result = num * num * num;
//                Console.WriteLine("Cube is" + result);


//            }

//                }

//        }
//}

// Q2. WAP to increase the load amount on electricity bill when consumption will be above 2500.load amount will be 5% of total bill otherwise provide 50% discount on electricity bill.??

//internal class IfElse
//{
//    internal void ElectricityBill()
//    {
//        float bill = 2344;
//        if(bill>2500)
//        {
//            bill = bill + (bill * 0.5f);
//            Console.WriteLine("Above consumbtion bill " +bill);
//        }
//        else
//        {
//            bill = bill / 2;
//            Console.WriteLine("Discounted bill "  +bill);

//        }
//    }
//}


//Q3.Example of Ladder if-else to calculate program of the greatest number? 


internal class ifElse
{

    internal void Ladder()
    {
        int a = 50, b = 200, c = 300;
        if(a>b && a>c)
        {
            Console.WriteLine("a is greatest");
        }
        else if(b>c) {
            Console.WriteLine("b is greatest");

        }
        else
        {
            Console.WriteLine("c is greatest");
        }

    }
}









