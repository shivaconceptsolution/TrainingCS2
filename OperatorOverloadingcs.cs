using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    class OperatorOverloadingcs
    {
        int x;
        OperatorOverloadingcs()
        {
        }
        OperatorOverloadingcs(int x)
        {
            this.x = x;
        }

        public static OperatorOverloadingcs operator+ (OperatorOverloadingcs o1,OperatorOverloadingcs o2)
        {
           OperatorOverloadingcs o = new OperatorOverloadingcs();
           o.x = o1.x - o2.x;
           return o;
        }
       public String ToString()
       {
           return "x =" + x;
       }

       static void Main()
       {
           OperatorOverloadingcs obj1 = new OperatorOverloadingcs(10);
           OperatorOverloadingcs obj2 = new OperatorOverloadingcs(20);
           OperatorOverloadingcs obj3 = obj1 + obj2;
           Console.WriteLine(obj3.ToString());
           Console.ReadKey();
       }
    }
}
