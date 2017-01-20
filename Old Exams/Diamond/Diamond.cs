using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int OutsideDots = n-1;
            int InsideDots =n*3;
            Console.Write(new string('.',n));
            Console.Write(new string('*', n * 3));
            Console.WriteLine(new string('.', n));
            for (int i = 1; i <= n-1; i++)
            {
                Console.Write(new string('.',OutsideDots));
                Console.Write("*");
                Console.Write(new string('.', InsideDots));
                Console.Write("*");
                Console.WriteLine(new string('.', OutsideDots));
                OutsideDots--;
                InsideDots+=2;
            }
            Console.WriteLine(new string('*', n * 5));
            OutsideDots = 1;
            InsideDots = (n * 5) - 4;
            for (int i = 1; i <= n*2; i++)
            {
                Console.Write(new string('.', OutsideDots));
                Console.Write("*");
                Console.Write(new string('.', InsideDots));
                Console.Write("*");
                Console.WriteLine(new string('.', OutsideDots));
                OutsideDots++;
                InsideDots -= 2;
            }
            InsideDots += 2;
            Console.Write(new string('.', OutsideDots));
            Console.Write(new string('*', InsideDots));
            Console.WriteLine(new string('.', OutsideDots));
        }
    }
}
