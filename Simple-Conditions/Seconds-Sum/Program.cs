using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seconds_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var sec1 = int.Parse(Console.ReadLine());
            var sec2 = int.Parse(Console.ReadLine());
            var sec3= int.Parse(Console.ReadLine());

            var TotalSeconds = sec1 + sec2 + sec3;

            var minutes = TotalSeconds / 60;
            var seconds = TotalSeconds % 60;

            if (seconds>9)
            {
                Console.WriteLine(minutes + ":" + seconds);
            }
            else
            {
                Console.WriteLine(minutes + ":0" + seconds);
            }
        }
    }
}
