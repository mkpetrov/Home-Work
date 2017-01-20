using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double Money = double.Parse(Console.ReadLine());
            int LastYear = int.Parse(Console.ReadLine());
            int CurentYears = 18;
            double RemainingMoney = Money;
            for (int i = 1800; i <= LastYear; i++)
            {
                if (i%2==0)
                {
                    RemainingMoney -= 12000;
                }
                else
                {
                    RemainingMoney -= (12000 + CurentYears * 50);
                }
                CurentYears++;
            }
            if (RemainingMoney>=0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.",RemainingMoney);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", Math.Abs(RemainingMoney));
            }
        }
    }
}
