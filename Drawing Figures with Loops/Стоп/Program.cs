using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Стоп
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var Points = new string('.',n + 1);
            var Dashes = new string('_',n*2+1);
            var PointsCount = n;
            var DashesCount = n*2-1;
            Console.WriteLine("{0}{1}{0}",Points,Dashes);

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('.', PointsCount));
                Console.Write("//");
                Console.Write(new string('_', DashesCount));
                Console.Write(@"\\");
                Console.WriteLine(new string('.', PointsCount));
                PointsCount -= 1;
                DashesCount += 2;
            }
            Console.Write("//");
            Console.Write(new string('_',(DashesCount-5)/2));
            Console.Write("STOP!");
            Console.Write(new string('_', (DashesCount - 5) / 2));
            Console.WriteLine(@"\\");
            Console.Write(@"\\");
            Console.Write(new string('_', DashesCount));
            Console.WriteLine("//");
            PointsCount = 1;
            DashesCount -= 2;
            for (int i = 1; i <= n - 1; i++)
            {
                Console.Write(new string('.', PointsCount));
                Console.Write(@"\\");
                Console.Write(new string('_', DashesCount));
                Console.Write("//");
                Console.WriteLine(new string('.', PointsCount));
                PointsCount += 1;
                DashesCount -= 2;
            }
        }
    }
}
