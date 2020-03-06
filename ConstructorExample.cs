using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    class ConstructorExample
    {
        static int x, y;
        int a, b;
        static ConstructorExample()
        {
            x = 10;
            y = 20;
            Console.WriteLine("Static Constructor");
        }
        ConstructorExample()
        {
            a = 100;
            b = 200;
        }
        ConstructorExample(int a, int b)
        {
          
            this.a = a;
            this.b = b;
        }

        ConstructorExample(ConstructorExample obj)
        {
            this.a = obj.a;
            this.b = obj.b;
        }
        public String ToString()
        {
            return "a=" + a + "b=" + b;
        }
        ~ConstructorExample()
        {
            Console.WriteLine("Destructor block");
            Console.ReadKey();
        }
        static void Main()
        {
            Console.WriteLine("Main");
            ConstructorExample obj = new ConstructorExample();
            GC.Collect();
            ConstructorExample obj1 = new ConstructorExample(10,20);
           // obj = obj1;
            ConstructorExample obj2 = new ConstructorExample(obj);
            GC.Collect();
            Console.WriteLine(obj.ToString());

            Console.WriteLine(obj1.ToString());
            Console.WriteLine(obj2.ToString());
            Console.ReadKey();
        }
    }
}
