using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Combination_20._11._16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int MaxCombinations = int.Parse(Console.ReadLine());
            int Counter = 0;
            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    Console.Write("<{0}-{1}>",i,j);
                    Counter++;
                    if (Counter==MaxCombinations)
                    {
                        break;
                    }
                }
                if (Counter==MaxCombinations)
                {
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}
