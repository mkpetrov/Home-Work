using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            while (a!=b)
            {
                if (a>b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            Console.WriteLine(a);
        }
    }
}
