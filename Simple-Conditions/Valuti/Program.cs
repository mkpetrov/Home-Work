using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuti
{
    class Program
    {
        static void Main(string[] args)
        {
            var bgn = 1;
            var bgntoUsd = 1.79549;
            var bgntoEur = 1.95583;
            var bgntoGbp = 2.53405;

            var number = double.Parse(Console.ReadLine());
            var from = Console.ReadLine();
            var to = Console.ReadLine();

            if (from=="USD")
            {
                number = number * bgntoUsd;
            }
            else if (from=="EUR")
            {
                number = number * bgntoEur;
            }
            else if (from=="GBP")
            {
                number = number * bgntoGbp;
            }
            if (to  == "USD")
            {
                number = number / bgntoUsd;
            }
            else if (to == "EUR")
            {
                number = number / bgntoEur;
            }
            else if (to == "GBP")
            {
                number = number / bgntoGbp;
            }

            Console.WriteLine(Math.Round(number,2));
        }
    }
}
