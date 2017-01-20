using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Numbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < numbers; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                
            }
            Console.WriteLine(sum);
        }
    }
}
