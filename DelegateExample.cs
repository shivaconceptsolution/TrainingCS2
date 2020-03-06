using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    class DelegateExample
    {
        public void fun()
        {
            Console.WriteLine("Fun");
        }
        public delegate void Mydel();
        static void Main()
        {
            DelegateExample obj = new DelegateExample();
            Mydel del = new Mydel(obj.fun);
            del();
            del();
            del();
            del();
            Console.ReadKey();
        }
    }
}
