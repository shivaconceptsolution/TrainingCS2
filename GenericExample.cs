using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    class GenericExample<T>
    {
        T a;
       internal GenericExample(T a)
        {
            this.a = a;
        }
        public T Fun()
        {
            return a;
        }

        
    }
    class GenericMain
    {
        public static void Main()
        {
            GenericExample<String> obj = new GenericExample<String>("hello world");

            Console.WriteLine(obj.Fun());

            Console.ReadKey();

        }
    }
}
