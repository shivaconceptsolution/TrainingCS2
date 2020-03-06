using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    class StringBuilderExample
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder("hello");
            sb.Append("World");
            StringBuilder sb1 = new StringBuilder("hello");
            sb1.Append("World");
            //String sb1 = "helloworld";
            if (sb==sb1)
            {
                Console.WriteLine("Equall");
            }
            else
                Console.WriteLine("Not equall");
            Console.WriteLine(sb);
            Console.ReadKey();
        }
    }
}
