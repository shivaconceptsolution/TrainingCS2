using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    class LoopExample
    {
        static void Main()
        {
         /*   int num = 5,i=1;
            bool flag = true;
            while (flag)
            {
                Console.WriteLine(num * i);
                i++;
                if (i > 10)
                 flag = false;

            }*/

            int i,num;

            for (i = 1,num = 5; i <= 10 && num <= 9; ++i) 
            {
                Console.WriteLine(i);
               
              
            }

            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 20);


            Console.ReadKey();
        }
    }
}
