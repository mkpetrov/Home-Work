using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class House
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var CountStarsEven = 2;
            var CountStarsOdd = 1;
            for (int i = 1; i <= (n+1)/2; i++)
            {
                if (i==1 && n%2==0)
                {
                    Console.Write(new string('-', (n - 2) / 2));
                    Console.Write("**");
                    Console.WriteLine(new string('-', (n - 2) / 2));
                }
                else if (i==1 && n%1==0)
                {
                    Console.Write(new string('-', (n - 1) / 2));
                    Console.Write("*");
                    Console.WriteLine(new string('-', (n - 1) / 2));
                }
                if (i>1 && n%2==0)
                {
                    var stars = CountStarsEven += 2;
                    Console.Write(new string('-', (n - CountStarsEven) / 2));
                    Console.Write(new string('*', CountStarsEven));
                    Console.WriteLine(new string('-', (n - CountStarsEven) / 2));
                }
                else if (i>1 && n%1==0)
                {
                    var stars = CountStarsOdd += 2;
                    Console.Write(new string('-', (n - CountStarsOdd) / 2));
                    Console.Write(new string('*', CountStarsOdd));
                    Console.WriteLine(new string('-', (n - CountStarsOdd) / 2));
                }

            }
            for (int i = 1; i <= n/2; i++)
            {
                Console.Write("|");
                Console.Write(new string('*', n - 2));
                Console.WriteLine("|");

            }
        }
    }
}
