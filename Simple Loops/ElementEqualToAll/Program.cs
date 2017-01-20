using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int SumNum = 0;
        int MaxNum = 0;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            
            if (number>=SumNum)
            {
                MaxNum = number;
                SumNum+=number;
            }
            else if (number<SumNum)
            {
                SumNum += number;
            }
        }
        SumNum -= MaxNum;

        if (SumNum==MaxNum)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("Sum = {0}",MaxNum);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("Diff = {0}",Math.Abs(SumNum-MaxNum));
        }
    }
}