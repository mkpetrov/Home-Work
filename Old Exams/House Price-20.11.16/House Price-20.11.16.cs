using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Price_20._11._16
{
    class Program
    {
        static void Main(string[] args)
        {
            double SmallesRoom = double.Parse(Console.ReadLine());
            double Kitchen = double.Parse(Console.ReadLine());
            double Price = double.Parse(Console.ReadLine());

            var Bathroom = SmallesRoom / 2;
            var SecondRoom = SmallesRoom+(SmallesRoom*0.10);
            var ThirdRoom = SecondRoom + (SecondRoom * 0.10);
            var SumRooms = SmallesRoom + Kitchen + Bathroom + SecondRoom + ThirdRoom;
            var area = SumRooms + (SumRooms * 0.05);
            var TotalPrice = area * Price;
            Console.WriteLine("{0:f2}",TotalPrice);
        }
    }
}
