using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    class GreatestExample
    {
        static void Main()
        {
            int a, b, c;
            Console.WriteLine("Enter First Number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Third Number");
            c = int.Parse(Console.ReadLine());
          /*  if (a > b)
            {
                if (a > c)
                    Console.WriteLine("a is greatest");
                else
                    Console.WriteLine("c is greatest");
            }
            else
            {
                if (b> c)
                    Console.WriteLine("b is greatest");
                else
                    Console.WriteLine("c is greatest");
            }*/

            if (a > b && a < c || a<b && a>c)
                Console.WriteLine("a is middle");
            else if (b>a && b<c || b<a &&  b>c)
                Console.WriteLine("b is middle");
            else
                Console.WriteLine("c is middle");
            Console.ReadKey(); 

        }
    }
}
