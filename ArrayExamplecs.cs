using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    class ArrayExamplecs
    {
        public static void Main()
        {
            int size;
            Console.WriteLine("Enter size of array");
            size = int.Parse(Console.ReadLine());
           // String[] arr = new String[size];
            //String arr = "abc";
            String [] arr = { "C", "CPP", "Java" };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter element for " + i + " Index");
                arr[i] = Console.ReadLine();
            }

            Console.WriteLine("Array elements is");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();



        }
    }
}
