using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstNumber = 1;
            int secondNumber = 1;
            int ThirdNumber = 0;

            
            for (int i = 2; i <= n; i++)
            {
                ThirdNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = ThirdNumber;
            }
            Console.WriteLine(ThirdNumber);
            if (n < 2)
            {
                Console.WriteLine("1");
            }

        }
    }
}
