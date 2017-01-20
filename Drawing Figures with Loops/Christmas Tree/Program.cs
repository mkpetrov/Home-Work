using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var firstRowSpaces = new string(' ',n + 1);
            var Pipes = magicString(" | ",1);
            Console.WriteLine("{0}|{0}",firstRowSpaces);
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.Write(new string('*', i));
                Console.Write(Pipes);
                Console.Write(new string('*', i));
                Console.Write(new string(' ', n - i));
                Console.WriteLine();
                
            }
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
