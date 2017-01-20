using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfProjection = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (typeOfProjection== "Premiere")
            {
                Console.WriteLine("{0:f2} leva",(r*c)*12);
            }
            else if (typeOfProjection== "Normal")
            {
                Console.WriteLine("{0:f2} leva", (r * c) * 7.50);
            }
            else if (typeOfProjection== "Discount")
            {
                Console.WriteLine("{0:f2} leva", (r * c) * 5.00);
            }
        }
    }
}
