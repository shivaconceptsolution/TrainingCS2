using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
     class Admin
    {
        int id;
        String sname;
      public void Acceept(int id, String sname)
        {
            this.id = id;
            this.sname = sname;
        }
        protected void Display()
        {
            Console.WriteLine("Id  is " + id + " Name is " + sname);
        }

        
    }

    class Emp : Admin
    {
        int salary;
        
        protected void Accept1(int salary)
        {
            base.Acceept(1002, "EMP");
            this.salary = salary;
        }
         protected void Display1()
        {
            base.Display();
            Console.WriteLine("Salary is " + salary);
        }

    }
    class OtherStaff : Emp
    {
        int bonus;
        
       internal void Accept2(int bonus)
        {
            base.Accept1(1200);
            this.bonus = bonus;
        }
       internal void Display2()
        {
            base.Display1();
            Console.WriteLine("Bonus is " + bonus);
        }

    }

    class EmpMain
    {
        static void Main()
        {
            Console.WriteLine("Other Staff Info");
            OtherStaff obj = new OtherStaff();
            obj.Accept2(1200);
            obj.Display2();
            Console.ReadKey();
        }

    }
}
