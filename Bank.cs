using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    interface Bank
    {
        int a { get; set; }
        string this[int number] { get; set; }
        void Credit();
        void Debit();
        void CheckBalance();
       
    }
    interface Account
    {
        void saving();
        void current();
    }
    class Bankimpl : Bank,Account
    {
        string [] arr = new string[2];
        public string this[int number] { 
            get {
            return arr[number];
             }
            set {
                 arr[number] = value;
            }
        }
        public int a
        {
            get
            {
                return a;

            }
            set
            {
                a = value;

            }
        }
        public void saving()
        {
        }
        public void current()
        {

        }
        public void Credit()
        {

        }
        public void Debit()
        {

        }
        public void CheckBalance()
        {

        }

        static void Main()
        {
            Bankimpl obj = new Bankimpl() ;
            obj[0] = "10";
            obj[1] = "12";
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(obj[i]);
            }
            obj.Credit();
            obj.Debit();
            Console.ReadKey();
        }
    }


}
