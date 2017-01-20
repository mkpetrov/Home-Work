using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            var USD = decimal.Parse(Console.ReadLine());
            var BGN = USD * 1.79549M;
            Console.WriteLine("{0:f2}",BGN);
        }
    }
}
