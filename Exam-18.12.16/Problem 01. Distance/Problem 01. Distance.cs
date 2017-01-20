using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01.Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            var StartingSpeed = int.Parse(Console.ReadLine());
            var FirstTime = int.Parse(Console.ReadLine());
            var SecndTime = int.Parse(Console.ReadLine());
            var ThirdTime = int.Parse(Console.ReadLine());

            var FirstTimeInH = FirstTime / 60.0;
            var SecondTimeInH = SecndTime / 60.0;
            var ThirdTimeInH = ThirdTime / 60.0;

            var SecondSpeed = StartingSpeed + (StartingSpeed * 0.10);
            var ThirdSpeed = SecondSpeed - (SecondSpeed * 0.05);

            var FirstDistance = StartingSpeed * FirstTimeInH;
            var SecondDistance = SecondSpeed * SecondTimeInH;
            var ThirdDistance = ThirdSpeed * ThirdTimeInH;

            var SumDistance = FirstDistance + SecondDistance + ThirdDistance;
            Console.WriteLine("{0:f2}",SumDistance);
        }
    }
}
