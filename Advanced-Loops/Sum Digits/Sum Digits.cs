using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sumNumbers = 0;
            while (num>0)
            {
                sumNumbers += num % 10;
                num = num / 10;
            }
            Console.WriteLine(sumNumbers);
        }
    }
}
