using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    enum WeekDays : int
    {
        sunday, monday, tuesday = 1, wednasday, friday, saturday
    }
    
    class EnumExample
    {
       
        static void Main()
        {
            
            Console.WriteLine((int)WeekDays.monday);
            Console.WriteLine((int)WeekDays.saturday);
            switch (WeekDays.monday)
            {
                case 0:
                    Console.WriteLine("not working days");
                    break;
                default:
                    Console.WriteLine("Working days");
                    break;
            }
            Console.ReadKey();
        }
    }
}
