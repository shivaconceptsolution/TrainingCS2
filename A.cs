using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    partial class A
    {
       internal void fun3()
        {
            Console.WriteLine("Class2");
        }

       static void Main()
       {
           A obj = new A();
           obj.fun3();
           obj.fun();
           obj.fun2();
           Console.ReadKey();

       }
    }
}
