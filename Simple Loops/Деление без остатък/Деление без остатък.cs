using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Деление_без_остатък
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToCount = int.Parse(Console.ReadLine());
            double numberDividetBy2 = 0;
            double numberDividetBy3 = 0;
            double numberDividetBy4 = 0;
            for (int i = 1; i <= numberToCount; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number%2==0)
                {
                    numberDividetBy2++;
                }
                if (number%3==0)
                {
                    numberDividetBy3++;
                }
                if (number%4==0)
                {
                    numberDividetBy4++;
                }
            }
            double P1 = numberDividetBy2 / numberToCount * 100;
            double P2 = numberDividetBy3 / numberToCount * 100;
            double P3 = numberDividetBy4 / numberToCount * 100;

            Console.WriteLine("{0:f2}%",P1);
            Console.WriteLine("{0:f2}%",P2);
            Console.WriteLine("{0:f2}%",P3);
        }
    }
}
