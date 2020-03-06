using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    class BoxingUnboxing
    {
        static void Main()
        {
            int a = 10;
            object o;
            o = a; //boxing
            Console.WriteLine(o);
            int b = (int)o;
            Console.WriteLine(b);

            String s = "123";
          //  int i = int.Parse(s);
            int i = Convert.ToInt32(s);
            Console.WriteLine(i);
            string s1 = "ab";
            String s2 = s1;
            int i1 = 101;
            Int64 i2 = i1;
           // Int64 i22 = new Int64();
            //i22 = 20;
            //UInt16 i3 = -12;
            Console.ReadKey();

        }
    }
}
