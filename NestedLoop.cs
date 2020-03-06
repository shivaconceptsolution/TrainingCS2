using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    class NestedLoop
    {
        static void Main()
        {
            for (int i = 65; i < 70; i++)
            {
                for (int j = 69; j >= i; j--)
                {
                    Console.Write((char)j + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
