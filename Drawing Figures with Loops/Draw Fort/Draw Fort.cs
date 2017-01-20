using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var TopThings = new string('^',n/2);
            var FortDashes = (n * 2) -(2*(2 + (n / 2)));

            Console.WriteLine(@"/{0}\{1}/{0}\",TopThings,new string('_',FortDashes));
            for (int i = 1; i <= n-3; i++)
            {
                Console.Write("|");
                Console.Write(new string(' ', n * 2 - 2));
                Console.WriteLine("|");
            }
            Console.Write("|");
            Console.Write(new string(' ',n/2+1));
            Console.Write(new string('_', FortDashes));
            Console.Write(new string(' ', n / 2+1));
            Console.WriteLine("|");
            Console.Write(@"\");
            Console.Write(new string('_',n/2));
            Console.Write("/");
            Console.Write(new string(' ', FortDashes));
            Console.Write(@"\");
            Console.Write(new string('_', n / 2));
            Console.WriteLine("/");
            

        }
    }
}
