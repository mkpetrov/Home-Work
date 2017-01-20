using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var bonusPoints = 0.0;
            if (number<=100)
            {
                bonusPoints+=5; 
            }
            else if (number<1000)
            {
                bonusPoints = number * 20 / 100;
            }
            else if (number>1000)
            {
                bonusPoints = number * 10 / 100;
            }
            if (number%2==0)
            {
                bonusPoints += 1;
            }
            if (number % 10 == 5)
            {
                bonusPoints += 2;
            }
            Console.WriteLine(bonusPoints);
            Console.WriteLine(number+bonusPoints);
            
        }
    }
}
