using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фирма
{
    class Program
    {
        static void Main(string[] args)
        {
            var NeededHours = int.Parse(Console.ReadLine());
            var Firmdays = double.Parse(Console.ReadLine());
            var ExtraHoursWorkers = int.Parse(Console.ReadLine());
            double studyDays = (Firmdays * 10) / 100;
            var lefthours = (Firmdays - studyDays) * 8;
            var extraHourswork = ExtraHoursWorkers * (2 * Firmdays);
            var sumHours = Math.Truncate(extraHourswork + lefthours);
            
            if (sumHours >= NeededHours)
            {
                var hoursPlus = Math.Truncate(sumHours - NeededHours);
                Console.WriteLine("Yes!{0} hours left.", (hoursPlus));
            }
            else
            {
                
                var enoughtime = NeededHours - sumHours;
                Console.WriteLine("Not enough time!{0} hours needed.", Math.Truncate(enoughtime));
            }
        }
    }
}
