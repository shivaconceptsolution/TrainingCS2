using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
   class C
    {
        internal static void fun()
        {

        }
    }
    static class StaticClassExample
    {
         static int a = 10;
         static StaticClassExample()
        {
            Console.WriteLine("C");
        }
        static internal void fun()
        {
            Console.WriteLine("a");
        }
      
    }
    class B
    {
        static void Main()
        {
            StaticClassExample.fun();
            Console.ReadKey();
        }
    }
}
