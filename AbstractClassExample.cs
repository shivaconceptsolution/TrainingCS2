using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    abstract class AbstractClassExample
    {
        internal void fun()
        {
            Console.WriteLine("Fun");
        }
        abstract internal void Triangle();
        abstract internal void Rectangle();

    }
    class Area:AbstractClassExample
    {

        internal override void Triangle()
        {
            Console.WriteLine("Triangle");
        }

        internal override void Rectangle()
        {
            Console.WriteLine("Rectangle");
        }

        public static void Main()
        {
            AbstractClassExample obj = new Area();
            obj.fun();
            obj.Triangle();
            obj.Rectangle();
            Console.ReadKey();
        }
    }
}
