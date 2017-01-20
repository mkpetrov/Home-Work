using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Поправка_на_плочки
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = double.Parse(Console.ReadLine());
            var W = double.Parse(Console.ReadLine());
            var L = double.Parse(Console.ReadLine());
            var M = double.Parse(Console.ReadLine());
            var O = double.Parse(Console.ReadLine());

            var sumArea = N * N;
            var bench = M * O;
            var CoverArea = sumArea - bench;
            var AreaTiles = W * L;
            var NeededTiles = CoverArea / AreaTiles;
            var NeededTime = NeededTiles * 0.2;
            Console.WriteLine(NeededTiles);
            Console.WriteLine(NeededTime);
        }
    }
}
