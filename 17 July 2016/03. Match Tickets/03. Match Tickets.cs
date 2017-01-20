using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double Budget = double.Parse(Console.ReadLine());
            string Category = Console.ReadLine();
            int fans = int.Parse(Console.ReadLine());

            var VIPNeededMoney = fans * 499.99;
            var NormlaNeededMoney = fans * 249.99;
            if (Category=="VIP")
            {
                if (fans<=4)
                {
                    var RemainingBudget = Budget - (Budget * 0.75);
                    if (RemainingBudget>=VIPNeededMoney)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.",RemainingBudget-VIPNeededMoney);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.",VIPNeededMoney-RemainingBudget);
                    }
                }
                else if (fans>4 && fans<=9)
                {
                    var RemainingBudget = Budget - (Budget * 0.60);
                    if (RemainingBudget >= VIPNeededMoney)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", RemainingBudget - VIPNeededMoney);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", VIPNeededMoney - RemainingBudget);
                    }
                }
                else if (fans>9 && fans<=24)
                {
                    var RemainingBudget = Budget - (Budget * 0.50);
                    if (RemainingBudget >= VIPNeededMoney)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", RemainingBudget - VIPNeededMoney);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", VIPNeededMoney - RemainingBudget);
                    }
                }
                else if (fans>24 && fans<=49)
                {
                    var RemainingBudget = Budget - (Budget * 0.40);
                    if (RemainingBudget >= VIPNeededMoney)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", RemainingBudget - VIPNeededMoney);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", VIPNeededMoney - RemainingBudget);
                    }
                }
                else if (fans>49)
                {
                    var RemainingBudget = Budget - (Budget * 0.25);
                    if (RemainingBudget >= VIPNeededMoney)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", RemainingBudget - VIPNeededMoney);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", VIPNeededMoney - RemainingBudget);
                    }
                }
            }
            if (Category == "Normal")
            {
                if (fans <= 4)
                {
                    var RemainingBudget = Budget - (Budget * 0.75);
                    if (RemainingBudget >= NormlaNeededMoney)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", RemainingBudget - NormlaNeededMoney);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", NormlaNeededMoney - RemainingBudget);
                    }
                }
                else if (fans > 4 && fans <= 9)
                {
                    var RemainingBudget = Budget - (Budget * 0.60);
                    if (RemainingBudget >= NormlaNeededMoney)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", RemainingBudget - NormlaNeededMoney);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", NormlaNeededMoney - RemainingBudget);
                    }
                }
                else if (fans > 9 && fans <= 24)
                {
                    var RemainingBudget = Budget - (Budget * 0.50);
                    if (RemainingBudget >= NormlaNeededMoney)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", RemainingBudget - NormlaNeededMoney);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", NormlaNeededMoney - RemainingBudget);
                    }
                }
                else if (fans > 24 && fans <= 49)
                {
                    var RemainingBudget = Budget - (Budget * 0.40);
                    if (RemainingBudget >= NormlaNeededMoney)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", RemainingBudget - NormlaNeededMoney);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", NormlaNeededMoney - RemainingBudget);
                    }
                }
                else if (fans > 49)
                {
                    var RemainingBudget = Budget - (Budget * 0.25);
                    if (RemainingBudget >= NormlaNeededMoney)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", RemainingBudget - NormlaNeededMoney);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", NormlaNeededMoney - RemainingBudget);
                    }
                }
            }
        }
    }
}
