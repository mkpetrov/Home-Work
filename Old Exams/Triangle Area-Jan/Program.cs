using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Area_Jan
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());
            y2 = y3;
            int a = x2 - x3;
            int h = y2 - y1;
            var S = (a * h) / 2.0;
            Console.WriteLine(S);
        }
    }
}
