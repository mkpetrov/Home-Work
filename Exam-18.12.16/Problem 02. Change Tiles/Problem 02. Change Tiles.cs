using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02.Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double Money = double.Parse(Console.ReadLine());
            double FloorWide = double.Parse(Console.ReadLine());
            double Floorlength = double.Parse(Console.ReadLine());
            double TriangleA = double.Parse(Console.ReadLine());
            double TriangleH = double.Parse(Console.ReadLine());
            double TilePrice = double.Parse(Console.ReadLine());
            double PriceWorker = double.Parse(Console.ReadLine());

            double FloorArea = Floorlength * FloorWide;
            double TriangleArea = (TriangleA * TriangleH) / 2;
            var NeededTiles =5+Math.Ceiling(FloorArea / TriangleArea);
            var SumPrice = (NeededTiles * TilePrice) + PriceWorker;

            if (Money>=SumPrice)
            {
                
                Console.WriteLine("{0:f2} lv left.",Money-SumPrice);
            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more.",SumPrice-Money);
            }
        }
    }
}
