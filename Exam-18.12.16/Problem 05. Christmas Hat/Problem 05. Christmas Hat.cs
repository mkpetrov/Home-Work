using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_05.Christmas_Hat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int OuterDots = n * 2 - 1;
            int InnerDashes = 1;
            var Pipes = magicString("*.",(4*n+1)/2);

            Console.WriteLine(@"{0}/|\{0}",new string('.',OuterDots),new string('.',OuterDots));
            Console.WriteLine(@"{0}\|/{0}",new string('.', OuterDots), new string('.', OuterDots));
            Console.WriteLine("{0}{1}{0}",new string('.',OuterDots),new string('*',3));
            OuterDots--;
            for (int i = 0; i < n*2-1; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}",new string('.',OuterDots),new string('-',InnerDashes));
                OuterDots--;
                InnerDashes++;
            }
            Console.WriteLine("{0}",new string('*',4*n+1));
            Console.WriteLine("{0}*",Pipes);
            Console.WriteLine("{0}", new string('*', 4 * n + 1));
        }




        public static string magicString(string text, int repearCount)
        {
            string OutputText = "";
            for (int i = 0; i < repearCount; i++)
            {
                OutputText = OutputText + text;
            }

            return OutputText;
        }
    }
}

