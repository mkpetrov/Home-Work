using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket_20._11._16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int OuterDots = ((3 * n) - 2) / 2;
            int InnerSpaces = 2;
            int InnerStars = (n * 2) - 2;
            Console.WriteLine(@"{0}/\{0}",new string('.',OuterDots));
            for (int i = 0; i < n-1; i++)
            {
                OuterDots--;
                Console.WriteLine(@"{0}/{1}\{0}",new string('.',OuterDots),new string(' ',InnerSpaces));
                InnerSpaces += 2;
            }
            Console.WriteLine("{0}{1}{0}",new string('.',OuterDots),new string('*',n*2));
            for (int i = 0; i < n*2; i++)
            {
                Console.WriteLine("{0}|{1}|{0}",new string('.',OuterDots),new string('\\',(n*2-2)));
            }
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine(@"{0}/{1}\{0}",new string('.',OuterDots),new string('*',InnerStars));
                OuterDots--;
                InnerStars += 2;
            }
        }
    }
}
