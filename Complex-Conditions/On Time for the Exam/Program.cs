using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int examTime = (examHour * 60) + examMinutes;
            int arrivalTime = (arrivalHour * 60) + arrivalMinutes;
            int OnTime = examTime - arrivalTime;
            if (examTime == arrivalTime)
            {
                Console.WriteLine("On time");
            }

            else if (OnTime<=30 && arrivalTime <= examTime)
            {
                int MMbeforeStart = examTime - arrivalTime;
                Console.WriteLine("On Time");
                Console.WriteLine("{0} minutes before the start", MMbeforeStart);
            }
            else if (examTime < arrivalTime)
            {
                int LateSumMM = arrivalTime - examTime;
                int LateHH = LateSumMM / 60;
                int LateMM = LateSumMM % 60;
                if (LateHH <= 0)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0} minutes after the start", LateMM);
                }
                else
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0}:{1:00} hours after the start", LateHH, LateMM);
                }
            }
            else if (examTime > arrivalTime && examTime > OnTime)
            {
                int EarlySumMM = examTime - arrivalTime;
                int EarlyHH = EarlySumMM / 60;
                int EatlyMM = EarlySumMM % 60;
                if (EarlyHH <= 0)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0} minutes before the start", EatlyMM);
                }
                else
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0}:{1:00} hours before the start", EarlyHH, EatlyMM);
                }
            }
        }
    }
}
