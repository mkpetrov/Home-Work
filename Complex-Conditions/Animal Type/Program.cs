using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal=Console.ReadLine().ToLower();
            if (animal=="dog")
            {
                Console.WriteLine("mammal");
            }
            else if (animal== "crocodile"||animal== "tortoise"||animal== "snake")
            {
                Console.WriteLine("reptile");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
