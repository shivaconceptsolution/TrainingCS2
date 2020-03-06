using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    class DataMemberExample
    {
        static int x = 100;
        private int y = 200;
        public int X { get; set; }
        public int Y
        {
            get
            {
                if (y < 0)
                    return 0;
                else
                    return 1;
            }
            set
            {
                y = value;
            }
        }
        static void Main()
        {
            int x = 20;

            bool b = true;
             DataMemberExample obj;
             obj = new DataMemberExample();
             obj.X = 2000;
             x = obj.y;
             long size = 0;
            object o = new object();
           
             using (Stream s = new MemoryStream())
             {
                 try
                 {
                     BinaryFormatter formatter = new BinaryFormatter();
                     formatter.Serialize(s, obj);
                     size = s.Length;
                     Console.WriteLine(size);
                 }
                 catch (Exception ex)
                 {
                     Console.WriteLine(ex.Message.ToString());
                 }
             }
            Console.WriteLine(DataMemberExample.x);
          
           
            Console.WriteLine(new DataMemberExample().y);
            Console.WriteLine(obj.y);
            Console.ReadKey();
        }
    }
}
