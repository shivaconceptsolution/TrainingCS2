using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    class Polymorphism
    {
       
        void sum(int a=10,int b=20,int c=30)
        {
            Console.WriteLine(a );
        }
        void sum(int a = 10, int b = 20)
        {
            Console.WriteLine(a + b);
        }
        void sum(int a)
        {
            Console.WriteLine("Common" + a);
        }

        void sum(int [] a)
        {
            Console.WriteLine("Common" + a);
        }
        void sum(Int16 a)
        {
            Console.WriteLine("Common " + a);
        }
        void sum(UInt32 a)
        {
            Console.WriteLine("Unsigned " + a);
        }
        static void Main()
        {
            Polymorphism obj = new Polymorphism();
            UInt32 i = 2;
            obj.sum(i);
            obj.sum(100);
            Console.ReadLine();
        }
    }
}
