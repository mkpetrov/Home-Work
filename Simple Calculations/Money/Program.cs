using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcoins = double.Parse(Console.ReadLine());
            var yuan = double.Parse(Console.ReadLine());
            var commision = double.Parse(Console.ReadLine());

            var bitcoinsToBGN = bitcoins * 1168;
            var yuanToUSN = yuan * 0.15;
            var USDtoBGN = yuanToUSN * 1.76;
            var SumEur = (bitcoinsToBGN + USDtoBGN) / 1.95;
            var CommisionEur = (SumEur * commision) / 100;
            Console.WriteLine(SumEur-CommisionEur);
        }
    }
}
