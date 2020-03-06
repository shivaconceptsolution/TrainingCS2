using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    static class IntegerExtension
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
        public static string Reverse(this string i)
        {

            return new String(i.ToCharArray().Reverse().ToArray());

        }
        static void Main()
        {
            int i=10;
           Console.WriteLine(i.IsGreaterThan(20));
           string s = "hello";
           Console.WriteLine(s.Reverse());
           Console.ReadKey();

        }
    }
}
