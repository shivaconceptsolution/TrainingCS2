using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    class JaggedExample
    {
        static void Main()
        {
            int[][] arr = new int[3][];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter column elements");
                int num = int.Parse(Console.ReadLine());
                arr[i] = new int[num];
               
                for (int j = 0; j < num; j++)
                {
                    Console.WriteLine("Enter element for " + i + j + " index");
                    arr[i][j] = int.Parse(Console.ReadLine());
                }

            }
            arr[0] = new int[3];
            arr[0][0] = 45;
            Console.WriteLine("Jagged element is");
            for (int i = 0; i < 3; i++)
            {
              
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]+" ");
                    
                }
                Console.WriteLine();

            }

            Console.ReadKey();

        }
    }
}
