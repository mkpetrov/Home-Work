using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Операции_между_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();

            if (symbol=="+")
            {
                double sum = number1 + number2;
                if (sum%2==0)
                {

                    Console.WriteLine("{0} + {1} = {2} - even",number1,number2,sum);
                }
                else
                {
                    Console.WriteLine("{0} + {1} = {2} - odd", number1, number2, sum);
                }
            }
            else if (symbol=="-")
            {
                double deff = number1 - number2;
                if (deff%2==0)
                {
                    Console.WriteLine("{0} - {1} = {2} - even", number1, number2, deff);
                }
                else
                {
                    Console.WriteLine("{0} - {1} = {2} - odd", number1, number2, deff);
                }
            }
            else if (symbol=="*")
            {
                double sum = number1 * number2;
                if (sum%2==0)
                {
                    Console.WriteLine("{0} * {1} = {2} - even", number1, number2, sum);
                }
                else
                {
                    Console.WriteLine("{0} * {1} = {2} - odd", number1, number2, sum);
                }
            }
            else if (symbol=="/")
            {
                double deff = number1 / number2;
                if (number2==0)
                {
                    Console.WriteLine("Cannot divide {0} by zero",number1);
                }
                else
                {
                    Console.WriteLine("{0} / {1} = {2:f2}",number1,number2,deff);
                }
            }
            else if (symbol=="%")
            {
                double deff = number1 % number2;
                if (number2==0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", number1);
                }
                else
                {
                    Console.WriteLine("{0} % {1} = {2}", number1,number2,Math.Truncate(deff));
                }
            }
        }
    }
}
