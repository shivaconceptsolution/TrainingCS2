using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    class MultiCastDelegate
    {
        public void Addition(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public void Substraction(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        public void Multiplication(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public void Division(int x, int y)
        {
            Console.WriteLine(x / y);
        }

        public delegate void CommonDel(int x, int y);
        public event CommonDel eventdel;
        static void Main()
        {
            MultiCastDelegate obj = new MultiCastDelegate();
          //  CommonDel cd=null;
            obj.eventdel += obj.Addition;
            obj.eventdel += obj.Substraction;
            obj.eventdel += obj.Multiplication;
            obj.eventdel += obj.Division;
            obj.eventdel(100, 20);
          //  cd -= obj.Multiplication;
          //  cd -= obj.Division;
          //  cd(10, 20);
            Console.ReadKey();

        }


    }
}
