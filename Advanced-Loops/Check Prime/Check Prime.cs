using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(n);
            bool prime = true;
            if (n < 2)
            {
                Console.WriteLine("Not Prime");
            }
            while (prime && (divider <= maxDivider))
            {
                if (n % divider == 0)
                {
                    prime = false;
                    Console.WriteLine("Not Prime");
                }
                divider++;
            }
            Console.WriteLine("Prime");

        }
    }
}
