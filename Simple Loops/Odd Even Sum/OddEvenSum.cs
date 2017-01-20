using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Sum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            int EnteringNumbers = int.Parse(Console.ReadLine());
            int SumEven = 0;
            int SumOdd = 0;
            for (int i = 0; i < EnteringNumbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    SumEven += number;
                }
                else
                {
                    SumOdd += number;
                }
            }
            if (SumEven==SumOdd)
            {
                Console.WriteLine("Yes Sum = {0}",SumEven);
            }
            else
            {
                int Diff = Math.Abs(SumEven-SumOdd);
                Console.WriteLine("No diff = {0}",Diff);
            }
        }
    }
}
