using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    class Class1
    {
        static void Main()
        {
            int a = 3,b;
            b = a++ + a++ + a++ + ++a;
       // 19    3     4     5      7
            Console.WriteLine("a = {0} ,b={1}", a, b);
            Console.ReadKey();

        }
    }
}
