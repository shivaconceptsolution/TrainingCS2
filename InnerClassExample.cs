using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    class InnerClassExample
    {
        class A
        {
           internal void fun()
            {
                Console.WriteLine("Inner Class A");
            }
        }
        static class B
        {
           internal static void fun1()
            {
                Console.WriteLine("Inner Class B");
            }
        }

        static void Main()
        {
            InnerClassExample.A obj = new InnerClassExample.A();
            obj.fun();
            InnerClassExample.B.fun1();
            Console.ReadKey();
        }
    }
}
