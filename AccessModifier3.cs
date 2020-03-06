using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{

    namespace CSHARP2
    {

        class AccessModifier3
        {
            internal void funnew()
            {
                Console.WriteLine("Internal New");
            }
            public static void Main()
            {
                AccessModifier obj = new AccessModifier();
                obj.fun1();
                obj.fun4();
                obj.fun5();
                Console.ReadKey();
            }
        }
    }
}
