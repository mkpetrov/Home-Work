using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Char
{
    class Char
    {
        static void Main(string[] args)
        {
            char l1 = char.Parse(Console.ReadLine());
            char l2 = char.Parse(Console.ReadLine());
            char l3 = char.Parse(Console.ReadLine());
            int Count = 0;
            for (char i = l1; i <= l2; i++)
            {
                for (char j = l1; j <= l2; j++)
                {
                    for (char k = l1; k <= l2; k++)
                    {
                        if (i!=l3 && j!=l3 && k!=l3)
                        {
                            Console.Write("{0}{1}{2} ", i, j, k);
                            Count++;
                        }
                    }
                }
            }
            Console.WriteLine(Count);
        }
    }
}
