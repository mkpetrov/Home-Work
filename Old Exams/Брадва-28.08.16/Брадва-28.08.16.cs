using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Брадва_28._08._16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int OuterDashes = n * 3;
            int InnerDashes = 0;
            int VaribaleDashes = (5 * n) - (n * 3 + 2);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{2}",new string('-',OuterDashes),new string('-',InnerDashes),new string('-',VaribaleDashes));
                InnerDashes++;
                VaribaleDashes--;
            }
            InnerDashes = n - 1;
            VaribaleDashes = n - 1;
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}{1}*{2}",new string('*',OuterDashes+1),new string('-',InnerDashes),new string('-',VaribaleDashes));
            }
            for (int i = 0; i < (n/2)-1; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', OuterDashes), new string('-', InnerDashes), new string('-', VaribaleDashes));
                OuterDashes--;
                InnerDashes += 2;
                VaribaleDashes--;
            }
            Console.WriteLine("{0}{1}{2}",new string('-',OuterDashes),new string('*',InnerDashes+2),new string('-',VaribaleDashes));
        }
    }
}
