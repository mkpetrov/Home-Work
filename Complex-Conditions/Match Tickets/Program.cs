using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int fans = int.Parse(Console.ReadLine());
            double sumVipPice = fans * 499.99;
            double sumNormalPrice = fans * 249.99;

            if (category=="VIP")
            {
                if (fans>=1 && fans<=4)
                {
                    double budgetAfterTransport = budget - (budget * 0.75);
                    if (sumVipPice>budgetAfterTransport)
                    {
                        double moneyNeeded = sumVipPice - budgetAfterTransport;
                        Console.WriteLine("Not enough money! You need {0:f2} leva.",moneyNeeded);
                    }
                    else
                    {
                        double moneyLeft = budgetAfterTransport - sumVipPice;
                        Console.WriteLine("Yes! You have {0:f2} leva left.",moneyLeft);
                    }
                }
                else if (fans>=5 && fans<=9)
                {
                    double budgetAfterTransport = budget - (budget * 0.60);
                    if (sumVipPice > budgetAfterTransport)
                    {
                        double moneyNeeded = sumVipPice - budgetAfterTransport;
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                    }
                    else
                    {
                        double moneyLeft = budgetAfterTransport - sumVipPice;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                    }
                }
                else if (fans>=10 && fans<=24)
                {
                    double budgetAfterTransport = budget - (budget * 0.50);
                    if (sumVipPice > budgetAfterTransport)
                    {
                        double moneyNeeded = sumVipPice - budgetAfterTransport;
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                    }
                    else
                    {
                        double moneyLeft = budgetAfterTransport - sumVipPice;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                    }
                }
                else if (fans>=24 && fans<=49)
                {
                    double budgetAfterTransport = budget - (budget * 0.40);
                    if (sumVipPice > budgetAfterTransport)
                    {
                        double moneyNeeded = sumVipPice - budgetAfterTransport;
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                    }
                    else
                    {
                        double moneyLeft = budgetAfterTransport - sumVipPice;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                    }
                }
                else if (fans>=50)
                {
                    double budgetAfterTransport = budget - (budget * 0.25);
                    if (sumVipPice > budgetAfterTransport)
                    {
                        double moneyNeeded = sumVipPice - budgetAfterTransport;
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                    }
                    else
                    {
                        double moneyLeft = budgetAfterTransport - sumVipPice;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                    }
                }
            }
            else if (category=="Normal")
            {
                if (fans >= 1 && fans <= 4)
                {
                    double budgetAfterTransport = budget - (budget * 0.75);
                    if (sumNormalPrice > budgetAfterTransport)
                    {
                        double moneyNeeded = sumNormalPrice - budgetAfterTransport;
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                    }
                    else
                    {
                        double moneyLeft = budgetAfterTransport - sumNormalPrice;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                    }
                }
                else if (fans >= 5 && fans <= 9)
                {
                    double budgetAfterTransport = budget - (budget * 0.60);
                    if (sumNormalPrice > budgetAfterTransport)
                    {
                        double moneyNeeded = sumNormalPrice - budgetAfterTransport;
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                    }
                    else
                    {
                        double moneyLeft = budgetAfterTransport - sumNormalPrice;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                    }
                }
                else if (fans >= 10 && fans <= 24)
                {
                    double budgetAfterTransport = budget - (budget * 0.50);
                    if (sumNormalPrice > budgetAfterTransport)
                    {
                        double moneyNeeded = sumNormalPrice - budgetAfterTransport;
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                    }
                    else
                    {
                        double moneyLeft = budgetAfterTransport - sumNormalPrice;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                    }
                }
                else if (fans >= 24 && fans <= 49)
                {
                    double budgetAfterTransport = budget - (budget * 0.40);
                    if (sumNormalPrice > budgetAfterTransport)
                    {
                        double moneyNeeded = sumNormalPrice - budgetAfterTransport;
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                    }
                    else
                    {
                        double moneyLeft = budgetAfterTransport - sumNormalPrice;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                    }
                }
                else if (fans >= 50)
                {
                    double budgetAfterTransport = budget - (budget * 0.25);
                    if (sumNormalPrice > budgetAfterTransport)
                    {
                        double moneyNeeded = sumNormalPrice - budgetAfterTransport;
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                    }
                    else
                    {
                        double moneyLeft = budgetAfterTransport - sumNormalPrice;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                    }
                }
            }

        }
    }
}
