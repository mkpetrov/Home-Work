using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int BitCoins = int.Parse(Console.ReadLine());
            double Yuan = double.Parse(Console.ReadLine());
            double Commision = double.Parse(Console.ReadLine());

            var YuanToDolars = Yuan * 0.15;
            var YuanToLv = YuanToDolars * 1.76;
            var SumLv = (BitCoins * 1168) + YuanToLv;

            var LvToEur = SumLv / 1.95;
            var EurAfterCommision = LvToEur - ((LvToEur * Commision)/100);
            Console.WriteLine(EurAfterCommision);
        }
    }
}
