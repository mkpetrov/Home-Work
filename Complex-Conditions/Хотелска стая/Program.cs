using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Хотелска_стая
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            if (month=="May" || month== "October")
            {
                if (nights<=7)
                {
                    double ApartmentPrice = nights * 65;
                    double StudioPrice = nights * 50;
                    Console.WriteLine("Apartment: {0:f2} lv.",ApartmentPrice);
                    Console.WriteLine("Studio: {0:f2} lv.",StudioPrice);
                }
                else if (nights>7 && nights<=14)
                {
                    double ApartmentPrice = nights * 65;
                    double StudioPrice = nights * (50 - (50*0.05));
                    Console.WriteLine("Apartment: {0:f2} lv.", ApartmentPrice);
                    Console.WriteLine("Studio: {0:f2} lv.", StudioPrice);
                }
                else if (nights>14)
                {
                    double ApartmentPrice = nights * (65-(65*0.10));
                    double StudioPrice = nights * (50 - (50 * 0.30));
                    Console.WriteLine("Apartment: {0:f2} lv.", ApartmentPrice);
                    Console.WriteLine("Studio: {0:f2} lv.", StudioPrice);
                }
            }
            else if (month== "June" || month== "September")
            {
                if (nights <=14 )
                {
                    double ApartmentPrice = nights * 68.70;
                    double StudioPrice = nights * 75.20;
                    Console.WriteLine("Apartment: {0:f2} lv.", ApartmentPrice);
                    Console.WriteLine("Studio: {0:f2} lv.", StudioPrice);
                }
                else if (nights > 14)
                {
                    double ApartmentPrice = nights * (68.70 - (68.70 * 0.10));
                    double StudioPrice = nights * (75.20 - (75.20 * 0.20));
                    Console.WriteLine("Apartment: {0:f2} lv.", ApartmentPrice);
                    Console.WriteLine("Studio: {0:f2} lv.", StudioPrice);
                }
            }
            else if (month== "July" || month== "August")
            {
                if (nights<=14)
                {
                    double ApartmentPrice = nights * 77;
                    double StudioPrice = nights * 76;
                    Console.WriteLine("Apartment: {0:f2} lv.", ApartmentPrice);
                    Console.WriteLine("Studio: {0:f2} lv.", StudioPrice);
                }
                else if (nights>14)
                {
                    double ApartmentPrice = nights * (77-(77*0.10));
                    double StudioPrice = nights * 76;
                    Console.WriteLine("Apartment: {0:f2} lv.", ApartmentPrice);
                    Console.WriteLine("Studio: {0:f2} lv.", StudioPrice);
                }
            }
        }
    }
}
