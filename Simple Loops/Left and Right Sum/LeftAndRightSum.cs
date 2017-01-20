using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_and_Right_Sum
{
    class LeftAndRightSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int LeftSum = 0;
            int RightSum = 0;
            for (int i = 0; i < n; i++)
            {
                LeftSum = LeftSum + int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                RightSum = RightSum + int.Parse(Console.ReadLine());
            }
            if (LeftSum==RightSum)
            {
                Console.WriteLine("Yes, sum = {0}",LeftSum);
            }
            else
            {
               var differnce= Math.Abs(LeftSum - RightSum);

                Console.WriteLine("No, diff = {0}",differnce);
            }
         
        }
    }
}
