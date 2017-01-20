using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = Math.Floor((double.Parse(Console.ReadLine())*100/120));
            var w = Math.Floor((double.Parse(Console.ReadLine())*100-100)/70);
            Console.WriteLine(h*w-3);

        }
    }
}
