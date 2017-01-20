using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дневна_печалба
{
    class Program
    {
        static void Main(string[] args)
        {
            var WorkDays = int.Parse(Console.ReadLine());
            var DaylyMoney = double.Parse(Console.ReadLine());
            var UsdToBgn = double.Parse(Console.ReadLine());

            var MonthPayment = WorkDays * DaylyMoney;
            var YearlyIncome = (MonthPayment * 12)+(MonthPayment*2.5);
            var tax = (YearlyIncome * 25) / 100;
            var CleanYearlyIncome = YearlyIncome - tax;
            var MidDaylyIncome = (CleanYearlyIncome/365)*UsdToBgn;
            Console.WriteLine("{0:f2}", MidDaylyIncome);
        }
    }
}
