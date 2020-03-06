using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    class StringExample
    {
        static void Main()
        {

            string s = "hello";
            Console.WriteLine(s.ToUpper());
            Console.WriteLine(s.ToLower());
            Console.WriteLine(s.Replace("h", "m"));
            var s1 = s.Reverse();
            Console.WriteLine(s.Remove(2));
            Console.WriteLine(s.IndexOf('l'));
            Console.WriteLine(s.LastIndexOf('l'));
            Console.WriteLine(s.PadLeft(s.Length + 3, '*'));
            Console.WriteLine(s.Substring(2));
            Console.WriteLine(s.StartsWith("h"));
            Console.WriteLine(s.EndsWith("o"));
            Console.WriteLine(s.Contains("l"));
            Console.WriteLine(s.Insert(1,"m"));
            String [] arr=s.Split('l');
            foreach(String o in arr)
            {
                Console.WriteLine(o);
            }
            

           /*foreach(char ch in s1)
            {
                Console.WriteLine(ch);
            }/*

          //  String s2 = "hello";
           /* Console.WriteLine(s);
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
            char[] arr = "hello".ToCharArray();
            String s1 = new String(arr);
            if (s==s1)
            {
                Console.WriteLine("equall");
            }
            else
            {
                Console.WriteLine("not equall");
            }


         //   s1="hello";
            Console.WriteLine(s1);*/



            Console.ReadKey();

        }
    }
}
