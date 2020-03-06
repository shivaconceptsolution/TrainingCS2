using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    class ObjectArr
    {
        static void Main()
        {
           // object []  arr = { "C", "C++", 12.34F, true, 'a' };
           // object [,] arr = { {"C", "C++","DS"},{ 12.34F, true, 'a'}};
           string [,] arr = { { "C", "C++", "DS" }, { "12.34F", "true","a" } };
           foreach(object  o in arr)
           {
              Console.Write(o+" ");
           }
            Console.ReadKey();



        }
    }
}
