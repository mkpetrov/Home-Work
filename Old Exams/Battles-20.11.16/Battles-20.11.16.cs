using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles_20._11._16
{
    class Program
    {
        static void Main(string[] args)
        {
            int Player1Pokemons = int.Parse(Console.ReadLine());
            int Player2Pokemons = int.Parse(Console.ReadLine());
            int Battles = int.Parse(Console.ReadLine());
            int BattlesCount = 0;
            for (int i =1; i <= Player1Pokemons; i++)
            {
                for (int j = 1; j <= Player2Pokemons; j++)
                {
                    Console.Write("({0} <-> {1}) ",i,j);
                    BattlesCount++;
                    if (BattlesCount==Battles)
                    {
                        break;
                    }
                }
                if (BattlesCount == Battles)
                {
                    break;
                }

            }
            Console.WriteLine();
        }
    }
}
