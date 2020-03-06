using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
   
    public class AccessModifier
    {
        private void fun()
        {
            Console.WriteLine("private");
        }
        internal void fun1()
        {
            Console.WriteLine("internal");
        }
        protected void fun3()
        {
            Console.WriteLine("protected");
        }
        protected internal void fun4()
        {
            Console.WriteLine("protected internal");
        }
        public void fun5()
        {
            Console.WriteLine("public");
        }
    }
}
