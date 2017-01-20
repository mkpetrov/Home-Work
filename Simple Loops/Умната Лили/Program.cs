using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Умната_Лили
{
    class Program
    {
        static void Main(string[] args)
        {
            int LiliAge = int.Parse(Console.ReadLine());
            double laundry = double.Parse(Console.ReadLine());
            int ToysPrice = int.Parse(Console.ReadLine());
            int AgeCount = LiliAge;
            int Money = 0;
            int SavedMoney = 0;
            int Toys = 0;
            int BrotherMoney = 0;

            for (int i = 1; i <= AgeCount; i++)
            {
                
                if (i%2==0)
                {
                    SavedMoney += 10;
                    Money = Money + SavedMoney;
                    BrotherMoney++;

                }
                else
                {
                    Toys++;
                }
            }
            int MoneyFromToys = Toys * ToysPrice;
            double SumMoney = (Money + MoneyFromToys)-BrotherMoney;
            if (SumMoney>=laundry)
            {
                double MoneyLeft = SumMoney - laundry;
                Console.WriteLine("Yes! {0:f2}",MoneyLeft);
            }
            else
            {
                double MoneyNeeded = laundry - SumMoney;
                Console.WriteLine("No! {0:f2}",MoneyNeeded);
            }
        }
    }
}
