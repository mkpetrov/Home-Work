using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int homeTownWeeks = int.Parse(Console.ReadLine());

            int weekends = 48;
            int weekendsInSofia = weekends - homeTownWeeks;
            double playsInSofia = weekendsInSofia * 3.0 / 4;
            double holidaysPlays = holidays * 2.0 / 3;
            double sumPlays = playsInSofia + homeTownWeeks + holidaysPlays;
            double leapPlays = sumPlays * 0.15;
            double sumLeapPlays = sumPlays + leapPlays;
            if (year=="leap")
            {
                Console.WriteLine(Math.Truncate(sumLeapPlays));
            }
            else
            {
                Console.WriteLine(Math.Truncate(sumPlays));
            }
        }
    }
}
