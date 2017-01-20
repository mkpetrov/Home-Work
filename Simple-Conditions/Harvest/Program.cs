using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());
            int Z = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            var SumGrape = X * Y;
            var Wine = 0.4 * SumGrape / 2.5;
            if (Wine<Z)
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.",Math.Floor(Z-Wine));
            }
            else
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.",Math.Floor(Wine));
                Console.WriteLine("{0} liters left -> {1} liters per person.",Math.Ceiling(Wine-Z),Math.Ceiling((Wine-Z)/workers));
            }
        }
    }
}
