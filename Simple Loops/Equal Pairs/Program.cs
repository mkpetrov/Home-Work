using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int CurrSum = 0;
            int OldSum = 0;
            int Diff = 0;
            int biggerDiff = 0;

            for (int i = 0; i < n; i++)
            {
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());
                if (i==0)
                {
                    OldSum = number1 + number2;
                }
                else
                {
                    CurrSum = number1 + number2;
                    Diff = Math.Abs(CurrSum - OldSum);
                    if (Diff>biggerDiff)
                    {
                        biggerDiff = Diff;
                    }
                    OldSum = CurrSum;
                }
            }
            if (biggerDiff==0)
            {
                Console.WriteLine("Yes, value ={0}",OldSum);
            }
            else
            {
                Console.WriteLine("No, maxdiff ={0}",biggerDiff);
            }
        }
    }
}
