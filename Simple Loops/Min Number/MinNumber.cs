using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Number
{
    class MinNumber
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int smallestNumber = int.MaxValue;
            for (int i = 0; i < numbersCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number<smallestNumber)
                {
                    smallestNumber = number;
                }
            }
            Console.WriteLine(smallestNumber);
        }
    }
}
