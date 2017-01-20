using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumbersCount = int.Parse(Console.ReadLine());
            double numberUnder200 = 0;
            double numberFrom200to399 = 0;
            double numberFrom400to599 = 0;
            double numberFrom600to799 = 0;
            double numberOver800 = 0;

            for (int i = 1; i <= NumbersCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number<200)
                {
                    numberUnder200++;
                }
                else if (number>=200 && number<=399)
                {
                    numberFrom200to399++;
                }
                else if (number>=400 && number<=599)
                {
                    numberFrom400to599++;
                }
                else if (number>=600 && number<=799)
                {
                    numberFrom600to799++;
                }
                else if (number>=800 && number<=1000)
                {
                    numberOver800++;
                }
            }
            double P1 = numberUnder200 / NumbersCount * 100;
            double P2 = numberFrom200to399 / NumbersCount * 100;
            double P3 = numberFrom400to599 / NumbersCount * 100;
            double P4 = numberFrom600to799 / NumbersCount * 100;
            double P5 = numberOver800 / NumbersCount * 100;

            Console.WriteLine("{0:f2}",P1);
            Console.WriteLine("{0:f2}",P2);
            Console.WriteLine("{0:f2}",P3);
            Console.WriteLine("{0:f2}",P4);
            Console.WriteLine("{0:f2}",P5);
        }
    }
}
