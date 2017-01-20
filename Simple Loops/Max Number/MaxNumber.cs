using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Number
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            int bigestNumber = int.MinValue;
            for (int i = 0; i < numberCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number>bigestNumber)
                {
                    bigestNumber = number;
                }
            }
            Console.WriteLine(bigestNumber);
        }
    }
}
