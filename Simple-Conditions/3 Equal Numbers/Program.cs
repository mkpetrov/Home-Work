using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = double.Parse(Console.ReadLine());
            var number2 = double.Parse(Console.ReadLine());
            var number3 = double.Parse(Console.ReadLine());

            if (number1==number2 && number2==number3 && number1==number3)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
