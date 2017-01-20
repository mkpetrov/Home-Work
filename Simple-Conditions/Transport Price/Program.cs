    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Transport_Price
    {
        class Program
        {
            static void Main(string[] args)
            {
                var km = int.Parse(Console.ReadLine());
                var PartOfTheDay = Console.ReadLine();
           
                if (km<20 && PartOfTheDay=="day")
                {
                    Console.WriteLine(km*0.79+0.70);
                }
                else if (km<20 && PartOfTheDay=="night")
                {
                    Console.WriteLine(km*0.90+0.70);
                }
                else if (km>=20 && km<100 )
                {
                    Console.WriteLine(km*0.09);
                }
                else if (km>=100)
                {
                    Console.WriteLine(km*0.06);
                }
            }
        }
    }
