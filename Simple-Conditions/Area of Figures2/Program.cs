using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures2
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double a = 0;
            double b = 0;
            double r = 0;
            double h = 0;
            double area = 0;
            if (figure== "square")
            {
                a = double.Parse(Console.ReadLine());
                area = a * a;
            }
            else if (figure== "rectangle")
            {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                area = a * b;
            }
            else if (figure== "circle")
            {
                r = double.Parse(Console.ReadLine());
                area = Math.PI * r * r;
            }
            else if (figure== "triangle")
            {
                a = double.Parse(Console.ReadLine());
                h = double.Parse(Console.ReadLine());
                area = (a * h) / 2;
            }
            Console.WriteLine("{0:f3}",area);
        }
    }
}
