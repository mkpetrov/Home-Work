using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var BonusScore = 0.0;
            if (number<=100)
            {
                BonusScore += 5;
            }
            else if (number>100 && number<1000)
            {
                BonusScore = (number * 20) / 100;
            }
            else if (number>1000)
            {
                BonusScore = (number * 10) / 100;
            }
            if (number%2==0)
            {
                BonusScore += 1;
            }
            else if (number%10==5)
            {
                BonusScore +=  2;
            }
            Console.WriteLine(BonusScore);
            Console.WriteLine(number+BonusScore);
        }
    }
}
