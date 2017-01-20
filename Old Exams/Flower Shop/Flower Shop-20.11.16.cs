using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int CountMagnols = int.Parse(Console.ReadLine());
            int CountHyacinths = int.Parse(Console.ReadLine());
            int CountRoses = int.Parse(Console.ReadLine());
            int CountCactuses = int.Parse(Console.ReadLine());
            double PresentPrice = double.Parse(Console.ReadLine());

            var Sum = (CountMagnols * 3.25) + (CountHyacinths * 4) + (CountRoses * 3.50) + (CountCactuses * 8);
            var SumAfterTax = Sum - (Sum * 0.05);
            if (PresentPrice>SumAfterTax)
            {
                Console.WriteLine("She will have to borrow {0} leva.",Math.Ceiling(PresentPrice-SumAfterTax));
            }
            else
            {
                Console.WriteLine("She is left with {0} leva.",Math.Floor(SumAfterTax-PresentPrice));
            }
        }
    }
}
