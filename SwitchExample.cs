using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    class SwitchExample
    {
        static void Main()
        {

            int a, b, c;
            Console.WriteLine("Enter First Number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            b = int.Parse(Console.ReadLine());
          /*  switch (a > b)
            {

                case true:
                    Console.WriteLine("a is greater");
                    break;
                default:
                    Console.WriteLine("b is greater");
                    break;
            }*/
            double d=12.0;
            switch ("hello")
            {

                case "hello":
                    switch ("hi")
                    {
                        case "hi":
                            Console.WriteLine("hi");
                            break;
                    }
                    Console.WriteLine("hello");
                    break;
            }
            Console.ReadKey();
        }
    }
}
