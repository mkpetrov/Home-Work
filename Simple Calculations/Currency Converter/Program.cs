using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var bgn = 1;
            var usd = bgn * 1.79549;
            var eur = bgn * 1.95583;
            var gbp = bgn * 2.53405;
            var number = double.Parse(Console.ReadLine());
            string from = Console.ReadLine();
            string to = Console.ReadLine();
            if (from=="USD")
            {
                number = number * usd;
            }
            else if (from=="EUR")
            {
                number = number * eur;
            }
            else if (from=="GBP")
            {
                number = number * gbp;
            }
            if (to=="USD")
            {
                number = number / usd;
            }
            else if (to=="EUR")
            {
                number = number / eur;
            }
            else if (to=="GBP")
            {
                number = number / gbp;
            }
            Console.WriteLine("{0:f2}", number);
        }
    }
}
