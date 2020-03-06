using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
   partial  class A
    {
        public virtual void fun()
        {
            Console.WriteLine("Parent Method");
        }
    }
    class OverhidingExample:A
    {
        public override  void fun()
        {
            Console.WriteLine("Child1 Method");
        }


    }
    class OverhidingExample1 : OverhidingExample
    {
       public override void fun()
        {
            Console.WriteLine("Child2 Method");
        }

       static void Main()
       {
           A obj = new A();
           obj.fun();

           OverhidingExample obj1 = new OverhidingExample1();
           obj1.fun();
           OverhidingExample1 obj2 = new OverhidingExample1();
           obj2.fun();
           Console.ReadKey();
       }

    }
}
