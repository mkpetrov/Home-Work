using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupid_Password_Generator
{
    class Program
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());



            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                    for (var l1 = 'a'; l1 < 'a' + L; l1++)
                        for (var l2 = 'a'; l2 < 'a' + L; l2++)
                            for (int num = Math.Max(i, j) + 1; num <= n; num++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ", i, j, l1, l2, num);
                            }
            Console.WriteLine();
        }
    }
}

