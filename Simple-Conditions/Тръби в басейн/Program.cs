using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тръби_в_басейн
{
    class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());
            double FilledWater = (P1 + P2) * H;
            if (FilledWater<=V)
            {
                double pipe1 = P1 * H / FilledWater * 100;
                double pipe2 = P2 * H / FilledWater * 100;
                double fillLevel = FilledWater / V * 100;
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%. ", Math.Truncate(fillLevel),Math.Truncate(pipe1),Math.Truncate(pipe2));
            }
            else
            {
                double overflow = FilledWater - V;
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",H,overflow);
            }
        }
    }
}
