using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets_20._11._16
{
    class Program
    {
        static void Main(string[] args)
        {
            int Days = int.Parse(Console.ReadLine());
            int Food = int.Parse(Console.ReadLine());
            double DogFood = double.Parse(Console.ReadLine());
            double CatFood = double.Parse(Console.ReadLine());
            double TurtleFood = double.Parse(Console.ReadLine());
            double TurtleFoodKg = TurtleFood / 1000;
            var NeededFood = (DogFood + CatFood + TurtleFoodKg) * Days;

            if (NeededFood<=Food)
            {
                Console.WriteLine("{0} kilos of food left.",Math.Floor(Food-NeededFood));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.",Math.Ceiling(NeededFood-Food));
            }
        }
    }
}
