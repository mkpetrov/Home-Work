using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftRight = (n-1)/2;
            int midDashesOdd = 1;
            int midDashesEven = 2;
            
            if (n%2==0)
            {
                Console.Write(new string('-', leftRight));
                Console.Write("**");
                Console.WriteLine(new string('-', leftRight));
                leftRight -= 1;
                for (int i = 1; i <= n/2-2; i++)
                {
                    Console.Write(new string('-', leftRight));
                    Console.Write("*");
                    Console.Write(new string('-', midDashesEven));
                    Console.Write("*");
                    Console.WriteLine(new string('-', leftRight));
                    leftRight -= 1;
                    midDashesEven += 2;
                }
                if (n!=2)
                {
                    Console.Write("*");
                    Console.Write(new string('-', n - 2));
                    Console.WriteLine("*");
                    leftRight = 1;
                    midDashesEven -= 2;
                }
                
                for (int i = 0; i <= n/2-2; i++)
                {
                    Console.Write(new string('-', leftRight));
                    Console.Write("*");
                    if (midDashesEven>=0)
                    {
                        Console.Write(new string('-', midDashesEven));
                        Console.Write("*");
                    }
                    Console.WriteLine(new string('-', leftRight));
                    leftRight += 1;
                    midDashesEven -= 2;
                }
            }
            else if (n % 1 == 0 && n!=2)
            {
                Console.Write(new string('-', leftRight));
                Console.Write("*");
                Console.WriteLine(new string('-', leftRight));
                leftRight -= 1;

                for (int i = 1; i <= (n - 2) / 2; i++)
                {
                    Console.Write(new string('-', leftRight));
                    Console.Write("*");
                    Console.Write(new string('-', midDashesOdd));
                    Console.Write("*");
                    Console.WriteLine(new string('-', leftRight));
                    leftRight -= 1;
                    midDashesOdd += 2;
                }
                if (n > 1)
                {
                    Console.Write("*");
                    Console.Write(new string('-', n - 2));
                    Console.WriteLine("*");
                    leftRight = 1;
                    midDashesOdd = (n - 2) - 2;
                }
                for (int i = 1; i <= n / 2; i++)
                {
                    Console.Write(new string('-', leftRight));
                    Console.Write("*");
                    if (midDashesOdd >= 0)
                    {
                        Console.Write(new string('-', midDashesOdd));
                        Console.Write("*");
                    }

                    Console.WriteLine(new string('-', leftRight));
                    leftRight += 1;
                    midDashesOdd -= 2;
                }

            }
        }
    }
}
