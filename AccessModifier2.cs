using System;

using CsharpTutorial.CSHARP2;
namespace CsharpTutorial
{
     
    class AccessModifier2:AccessModifier
    {
        public static void Main()
        {
            AccessModifier2 obj = new AccessModifier2();
           // AccessModifier3 obj1 = new AccessModifier3();
           // obj1.funnew();
            obj.fun1();
            obj.fun4();
            obj.fun3();
            obj.fun5();
            Console.ReadKey();
        }
    }
}
