using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    class TernaryExample
    {
        const int A = 20;
        static void Main()
        {
            const int A = 100;
           // A = 20;
            //TernaryExample obj = new TernaryExample();
            Console.WriteLine(TernaryExample.A);
            int num;
            Console.WriteLine("Enter year");
            num = int.Parse(Console.ReadLine());
            String result = (num % 400==0 )? "leap year":((num%100==0)?"not leap year":(num%4==0?"leap year":"not a leap year")) ;
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
