using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            if (product== "kiwi"||product== "cherry"||product== "lemon"||product== "grapes"||product== "banana"||product== "apple")
            {
                Console.WriteLine("fruit");
            }
            else if (product== "tomato"||product== "cucumber"||product== "pepper"||product== "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
