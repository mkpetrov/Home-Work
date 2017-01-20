using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dash = magicString(" -",n-2);
            Console.WriteLine("+{0} +",dash);
            for (int i = 1; i <= n-2; i++)
            {
                Console.WriteLine("|{0} |",dash);
            }
            Console.WriteLine("+{0} +", dash);
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
