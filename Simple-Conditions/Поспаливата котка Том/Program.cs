using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Поспаливата_котка_Том
{
    class Program
    {
        static void Main(string[] args)
        {
            var RestDays = int.Parse(Console.ReadLine());
            var WorkDay = 365 - RestDays;
            var CatRestDays = RestDays * 127 ;
            var CatWorkDays = WorkDay * 63 ;
            var sumCatDays = CatRestDays + CatWorkDays;

            if (sumCatDays<=30000)
            {
                var CatSleepHours = 30000 - sumCatDays;
                var hours = CatSleepHours / 60;
                var minutes = CatSleepHours % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play",hours,minutes);
            }
            else
            {
                var CatPlayHours = sumCatDays - 30000;
                var hours = CatPlayHours / 60;
                var minutes = CatPlayHours % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play",hours,minutes);
            }
        }

    }
}
