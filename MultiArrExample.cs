using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{

    class MultiArrExample
    {
        static void Main()
        {
            int r, c;
            Console.WriteLine("Enter rows");
            r = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter columns");
            c = int.Parse(Console.ReadLine());
            int [,,] arr = new int[r,c,c];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    for (int k = 0; k < 1; k++)
                    {
                        Console.WriteLine("Enter element for " + i + j +k+ " index");
                        arr[i, j,k] = int.Parse(Console.ReadLine());
                    }
                }
            }
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        Console.Write(arr[i, j,k] + " ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
