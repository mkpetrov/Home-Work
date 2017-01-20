using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox_20._11._16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int Stars = 1;
            int Dashes = (n * 2) - 1;
            int InnerStars = n;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(@"{0}\{1}/{0}",new string('*',Stars),new string('-',Dashes));
                Stars++;
                Dashes -= 2;
            }
            Stars = n / 2;
            for (int i = 0; i < n/3; i++)
            {
                
                Console.WriteLine(@"|{0}\{1}/{0}|",new string('*',Stars),new string('*',InnerStars));
                Stars++;
                InnerStars -= 2;
            }
            Stars = (n * 2) - 1;
            Dashes = 1;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(@"{0}\{1}/{0}", new string('-', Dashes), new string('*', Stars));
                Dashes++;
                Stars -= 2;
            }
        }
    }
}
