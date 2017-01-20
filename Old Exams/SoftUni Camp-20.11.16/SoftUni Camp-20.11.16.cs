using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Camp_20._11._16
{
    class Program
    {
        static void Main(string[] args)
        {
            int Groups = int.Parse(Console.ReadLine());
            var PeopleWithCar = 0.0;
            var PeopleWithMicroBus = 0.0;
            var PeopleWithLittleBus = 0.0;
            var PeopleWithBus = 0.0;
            var PeopleWithTrain = 0.0;
            int SumPeople = 0;
            for (int i = 0; i < Groups; i++)
            {
                int PeopleInGroup = int.Parse(Console.ReadLine());
                SumPeople += PeopleInGroup;
                if (PeopleInGroup<=5)
                {
                    PeopleWithCar += PeopleInGroup;
                }
                else if (PeopleInGroup >= 6 && PeopleInGroup <= 12)
                {
                    PeopleWithMicroBus += PeopleInGroup;
                }
                else if (PeopleInGroup>=13 && PeopleInGroup<=25)
                {
                    PeopleWithLittleBus += PeopleInGroup;
                }
                else if (PeopleInGroup>=26 && PeopleInGroup<=40)
                {
                    PeopleWithBus += PeopleInGroup;
                }
                else if (PeopleInGroup>40)
                {
                    PeopleWithTrain += PeopleInGroup;
                }
            }
            var PercentCar = (PeopleWithCar / SumPeople) * 100;
            var PercentMicrobus = (PeopleWithMicroBus / SumPeople) * 100;
            var PercentLittleBus = (PeopleWithLittleBus / SumPeople) * 100;
            var PercentBus = (PeopleWithBus / SumPeople) * 100;
            var PercentTrain = (PeopleWithTrain / SumPeople) * 100;

            Console.WriteLine("{0:f2}%",PercentCar);
            Console.WriteLine("{0:f2}%",PercentMicrobus);
            Console.WriteLine("{0:f2}%",PercentLittleBus);
            Console.WriteLine("{0:f2}%",PercentBus);
            Console.WriteLine("{0:f2}%",PercentTrain);
        }
    }
}
