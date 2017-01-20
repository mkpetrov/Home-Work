using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics_20._11._16
{
    class Program
    {
        static void Main(string[] args)
        {
            int Loads = int.Parse(Console.ReadLine());
            var BusLoads = 0.0;
            var TruckLoads = 0.0;
            var TrainLoads = 0.0;
            var SumTons = 0.0;
            for (int i = 0; i < Loads; i++)
            {
                int Tons = int.Parse(Console.ReadLine());
                SumTons += Tons;
                if (Tons<=3)
                {
                    BusLoads+=Tons;
                }
                else if (Tons>3 && Tons<12)
                {
                    TruckLoads+=Tons;
                }
                else if (Tons>=12)
                {
                    TrainLoads+=Tons;
                }
            }
            double AveragePricePerTon = (BusLoads * 200 + TruckLoads * 175 + TrainLoads * 120) / SumTons;
            double BusPercents = (BusLoads / SumTons) * 100;
            double TruckPercents = (TruckLoads / SumTons) * 100;
            double TrainPercents = (TrainLoads / SumTons) * 100;
            Console.WriteLine("{0:f2}",AveragePricePerTon);
            Console.WriteLine("{0:f2}%",BusPercents);
            Console.WriteLine("{0:f2}%",TruckPercents);
            Console.WriteLine("{0:f2}%",TrainPercents);
        }
    }
}
