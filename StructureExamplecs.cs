using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    struct Student
    {
        int rno;
        String sname;
        static Student()
        {
            Console.WriteLine("hello");
        }
       internal void accept(int rno, String sname)
        {
            this.rno = rno;
            this.sname = sname;
        }
        internal void display()
        {
            Console.WriteLine("rno is " + this.rno + " " + "name is " + this.sname);
        }
    }
    class StructureExamplecs
    {
        static void Main()
        {
             Student obj=new Student();
            obj.accept(1001, "xyz");
            obj.display();
            Console.ReadKey();
        }
    }
}
