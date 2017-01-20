using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double mackerelPrice = double.Parse(Console.ReadLine());
            double spratPrice = double.Parse(Console.ReadLine());
            double beltedBonitoKg = double.Parse(Console.ReadLine());
            double scadKg = double.Parse(Console.ReadLine());
            int clamsKg = int.Parse(Console.ReadLine());

            var beltedBonitoPrice = mackerelPrice + (mackerelPrice * 0.60);
            var scadPrice = spratPrice + (spratPrice * 0.80);

            var Sum = (beltedBonitoKg * beltedBonitoPrice) + (scadKg * scadPrice) + (clamsKg * 7.50);
            Console.WriteLine("{0:f2}",Sum);
        }
    }
}
