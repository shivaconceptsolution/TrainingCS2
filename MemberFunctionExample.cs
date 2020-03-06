using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    class MemberFunctionExample
    {
        void display( int a, out int b) //out
        {
            b = a * a;
        }
        void display(int a=10, int b=20) //optional,default
        {
            Console.WriteLine(a + b);
        }
        String display(String a,String b)
        {
            return a + "," + b;
        }
        static void Main()
        {
            MemberFunctionExample obj = new MemberFunctionExample();
            int a=10,b;
            obj.display(a,out  b);
            Console.WriteLine(b);
            obj.display(a);
            obj.display();
            obj.display(100, 20);
           String param = obj.display("abc","xyz");
            String param2 = obj.display(a: "abc", b: "xyz");
            Console.WriteLine(param2);
            String param1 = obj.display(b: "abc", a: "xyz");
            Console.WriteLine(param1);
            Console.ReadKey();

        }
    }
}
