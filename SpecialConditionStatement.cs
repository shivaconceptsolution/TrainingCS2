using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    class SpecialConditionStatement
    {
        static void Main()
        {
            int i;
            data:
            Console.WriteLine("hello");
            for (i = 2; i <= 20; i++)
            {
              
                if (i ==1)
                    break;
                Console.WriteLine(i);
                if (i == 7)
                    goto data;



            }

            Console.ReadKey();

        }
    }
}
