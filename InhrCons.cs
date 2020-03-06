using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    sealed class InhrCons
    {
        internal int a=100;
        internal InhrCons()
        {
            a = 2;
        }
        internal InhrCons(int a)
        {
            Console.WriteLine("parent" + a);
        }
        internal InhrCons(String b)
        {
            Console.WriteLine(b);
        }
    }
    class InhrCons1
    {
        string con="hello";
        internal InhrCons1(int a)
        {

            Console.WriteLine(a);
        }
    }
    class InhrMain
    {
        static void Main()
        {
            InhrCons obj = new InhrCons(10);
            Console.ReadKey();
        }
    }

}
