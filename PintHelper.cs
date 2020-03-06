using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    class PrintHelper
    {
         // declare delegate 
    public delegate void BeforePrint();
    
    //declare event of type delegate
    public event BeforePrint beforePrintEvent;
    public event BeforePrint afterPrintEvent;   
    public PrintHelper()
    {

    }

    public void PrintNumber(int num)
    {
        //call delegate method before going to print
        if (beforePrintEvent != null)
            beforePrintEvent();

        Console.WriteLine("Number: {0,-12:N0}", num);
        if (afterPrintEvent != null)
            afterPrintEvent();
    }

    public void PrintDecimal(int dec)
    {
        if (beforePrintEvent != null)
            beforePrintEvent();
    
        Console.WriteLine("Decimal: {0:G}", dec);
    }

    public void PrintMoney(int money)
    {
        if (beforePrintEvent != null)
            beforePrintEvent();

        Console.WriteLine("Money: {0:C}", money);
    }

    public void PrintTemperature(int num)
    {
        if (beforePrintEvent != null)
            beforePrintEvent();

        Console.WriteLine("Temperature: {0,4:N1} F", num);
    }
    public void PrintHexadecimal(int dec)
    {
        if (beforePrintEvent != null)
            beforePrintEvent();

        Console.WriteLine("Hexadecimal: {0:X}", dec);
    }
    }

    class Number
    {
        private PrintHelper _printHelper;

        public Number(int val)
        {
            _value = val;

            _printHelper = new PrintHelper();
            //subscribe to beforePrintEvent event
            _printHelper.beforePrintEvent += _printHelper_beforePrintEvent;
            _printHelper.afterPrintEvent += _printHelper_afterPrintEvent;
        }

        void _printHelper_afterPrintEvent()
        {
            Console.WriteLine("After");
        }

        void _printHelper_beforePrintEvent()
        {
            Console.WriteLine("Before");
        }
        

        private int _value;

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public void PrintMoney()
        {
            _printHelper.PrintMoney(_value);
        }

        public void PrintNumber()
        {
            _printHelper.PrintNumber(_value);
        }
        public void PrintHexa()
        {
            _printHelper.PrintHexadecimal(_value);
        }
        static void Main()
        {
            Number obj = new Number(100);
            obj.PrintNumber();
          //  obj.PrintHexa();
            Console.ReadKey();
        }
    }
}

