using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int Elderly = int.Parse(Console.ReadLine());
            int Students = int.Parse(Console.ReadLine());
            int Nights = int.Parse(Console.ReadLine());
            string Transport = Console.ReadLine();
            int CountPeople = Elderly + Students;
            var SumTransport = 0.0;

            if (Transport=="train")
            {
                if (CountPeople>=50)
                {
                    var elderlyPrice = (24.99 * Elderly) / 2;
                    var StudentsPrice = (14.99 * Students) / 2;
                    SumTransport = elderlyPrice + StudentsPrice;
                }
                else
                {
                    var elderlyPice = 24.99 * Elderly;
                    var StudentsPrice = 14.99 * Students;
                    SumTransport = elderlyPice + StudentsPrice;
                }
            }
            else if (Transport=="bus")
            {
                var elderlyPrice = 32.50 * Elderly;
                var StudentsPrice = 28.50 * Students;
                SumTransport = elderlyPrice + StudentsPrice;
            }
            else if (Transport=="boat")
            {
                var elderlyPrice = 42.99 * Elderly;
                var StudentsPrice = 39.99 * Students;
                SumTransport = elderlyPrice + StudentsPrice;
            }
            else if (Transport=="airplane")
            {
                var elderlyPrice = 70.00 * Elderly;
                var StudentsPrice = 50.00 * Students;
                SumTransport = elderlyPrice + StudentsPrice;
            }
            
            var NightsPrice = Nights * 82.99;
            var SumPrice = SumTransport*2 + NightsPrice;
            var SumAfterTax = SumPrice + (SumPrice * 0.10);
            Console.WriteLine("{0:f2}",SumAfterTax);
        }
    }
}
