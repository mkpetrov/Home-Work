﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int Hriz = int.Parse(Console.ReadLine());
            int Roses = int.Parse(Console.ReadLine());
            int Lal = int.Parse(Console.ReadLine());
            string Season = Console.ReadLine();
            string Holiday = Console.ReadLine();
            var SumFlowers = Hriz + Roses + Lal;

            var HrizPrice = 0.0;
            var RosesPrice = 0.0;
            var LalPrice = 0.0;
            var Sum = 0.0;
            
            

            if (Season=="Spring")
            {
                HrizPrice = Hriz * 2.00;
                RosesPrice = Roses * 4.10;
                LalPrice = Lal * 2.50;
                Sum = HrizPrice + RosesPrice + LalPrice;
            }
            else if (Season=="Summer")
            {
                HrizPrice = Hriz * 2.00;
                RosesPrice = Roses * 4.10;
                LalPrice = Lal * 2.50;
                Sum = HrizPrice + RosesPrice + LalPrice;
            }
            else if (Season=="Autumn")
            {
                HrizPrice = Hriz * 3.75;
                RosesPrice = Roses * 4.50;
                LalPrice = Lal * 4.15;
                Sum = HrizPrice + RosesPrice + LalPrice;
            }
            else if (Season=="Winter")
            {
                HrizPrice = Hriz * 3.75;
                RosesPrice = Roses * 4.50;
                LalPrice = Lal * 4.15;
                Sum = HrizPrice + RosesPrice + LalPrice;
            }
            if (Holiday=="Y")
            {
                Sum = Sum + (Sum * 0.15);
            }
            if (Season=="Spring" && Lal>=7)
            {
                Sum = Sum - (Sum * 0.05);
            }
            if (Season=="Winter" && Roses>=10)
            {
                Sum = Sum - (Sum * 0.10);
            }
            if (SumFlowers>=20)
            {
                Sum = Sum - (Sum * 0.20);
            }
            Sum = Sum + 2;
            Console.WriteLine("{0:f2}",Sum);
            
        }
    }
}
