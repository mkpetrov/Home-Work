    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Зеленчукова_борса
{
    class Program
    {
        static void Main(string[] args)
        {
     
            var PriceKiloVeg = double.Parse(Console.ReadLine());
            var PriceKiloFrt = double.Parse(Console.ReadLine());
            var KiloVeg = int.Parse(Console.ReadLine());
            var KiloFrt = int.Parse(Console.ReadLine());
            var SumKiloVeg = PriceKiloVeg * KiloVeg;
            var SumKiloFr = PriceKiloFrt * KiloFrt;
            var value = SumKiloFr + SumKiloVeg;
            Console.WriteLine(value/1.94);
        }
    }
}
