﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            var totalMin = minutes + 15;
            var totalhour = hour + totalMin / 60;
            var minutesAfterHour = totalMin % 60;
            if (totalhour==24)
            {
                Console.WriteLine("0:{0:00}", minutesAfterHour);
            }
            else
            {
                Console.WriteLine("{0:0}:{1:00}",totalhour,minutesAfterHour);
            }
        }
    }
}
