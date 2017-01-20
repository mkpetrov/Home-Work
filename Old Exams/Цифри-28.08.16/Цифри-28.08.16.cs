using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Цифри_28._08._16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int Smolestn = 0;
            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            int SubN = n;
            for (int i = 1; i <= 3; i++)
            {
                if (i==1)
                {
                    n3 = n % 10;
                    Smolestn = n / 10; ;
                }
                else if (i==2)
                {
                    n2 = Smolestn % 10;
                    Smolestn = Smolestn/10;
                }
                else
                {
                    n1 = Smolestn;
                }
            }
            Console.WriteLine();
            int row = n1 + n2;
            int col = n1 + n3;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (SubN%5==0)
                    {
                         SubN = SubN - n1;
                    }
                    else if (SubN%3==0)
                    {
                        SubN = SubN - n2;
                    }
                    else
                    {
                        SubN = SubN + n3;
                    }
                    Console.Write("{0} ",SubN);
                }
                Console.WriteLine();
            }
        }
    }
}
