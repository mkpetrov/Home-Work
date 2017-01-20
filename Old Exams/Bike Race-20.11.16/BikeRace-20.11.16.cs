using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Race_20._11._16
{
    class Program
    {
        static void Main(string[] args)
        {
            int CountJuniors = int.Parse(Console.ReadLine());
            int CountSeniors = int.Parse(Console.ReadLine());
            string TypeOfRace = Console.ReadLine();

            var JuniorTaxes = 0.0;
            var SeniorsTaxes = 0.0;

            if (TypeOfRace=="trail")
            {
                JuniorTaxes = CountJuniors * 5.50;
                SeniorsTaxes = CountSeniors * 7;   
            }
            else if (TypeOfRace=="cross-country")
            {
                var CountBikers = CountJuniors + CountSeniors;
                if (CountBikers>=50)
                {
                    JuniorTaxes = (CountJuniors * 8) - ((CountJuniors * 8) * 0.25);
                    SeniorsTaxes = (CountSeniors * 9.50) - ((CountSeniors * 9.50) * 0.25);
                }
                else
                {
                    JuniorTaxes = CountJuniors * 8;
                    SeniorsTaxes = CountSeniors * 9.50;
                }
            }
            else if (TypeOfRace== "downhill")
            {
                JuniorTaxes = CountJuniors * 12.25;
                SeniorsTaxes = CountSeniors * 13.75;
            }
            else if (TypeOfRace== "road")
            {
                JuniorTaxes = CountJuniors * 20;
                SeniorsTaxes = CountSeniors * 21.50;
            }
            var SumTaxes = JuniorTaxes + SeniorsTaxes;
            var SumAfterPays = SumTaxes - (SumTaxes * 0.05);
            Console.WriteLine("{0:f2}", SumAfterPays);
        }
    }
}
