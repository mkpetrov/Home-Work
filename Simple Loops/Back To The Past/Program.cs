using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double InheritedMoney = double.Parse(Console.ReadLine());
            int YearToLeave = int.Parse(Console.ReadLine());
            int IvanchoYears = 17;
            int EvenSpends = 0;
            int OddSpends = 0;
            for (int i = 1800; i <= YearToLeave; i++)
            {
                IvanchoYears++;
                if (i%2==0)
                {
                    EvenSpends += 12000;
                }
                else
                {
                    OddSpends += 12000 + (50 * IvanchoYears);
                }
            }
            double SumSpend = EvenSpends + OddSpends;
            if (InheritedMoney>=SumSpend)
            {
                double MoneyLeft = InheritedMoney - SumSpend; 
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.",MoneyLeft);
            }
            else
            {
                double MoneyNeeded = SumSpend - InheritedMoney;
                Console.WriteLine("He will need {0:f2} dollars to survive.",MoneyNeeded);
            }

        }
    }
}
