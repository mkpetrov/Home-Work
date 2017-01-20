using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int Students = int.Parse(Console.ReadLine());
            var Grades = 0.0;
            var TopStudents = 0.0;
            var Grade4to5 = 0.0;
            var Grade3to4 = 0.0;
            var Grade2to3 = 0.0;

            for (int i = 0; i < Students; i++)
            {
                double Grade = double.Parse(Console.ReadLine());
                Grades += Grade;
                if (Grade>=5.00)
                {
                    TopStudents++;
                }
                else if (Grade>=4.00 && Grade<5.00)
                {
                    Grade4to5++;
                }
                else if (Grade >= 3.00 && Grade < 4.00)
                {
                    Grade3to4++;
                }
                else if (Grade >= 2.00 && Grade < 3.00)
                {
                    Grade2to3++;
                }
            }
            var AverageGrade = Grades / Students;

            var Top = (TopStudents / Students) * 100;
            var Between4and5 = (Grade4to5 / Students) * 100;
            var Between3and4 = (Grade3to4 / Students) * 100;
            var Fail = (Grade2to3 / Students) * 100;

            Console.WriteLine("Top students: {0:f2}%",Top);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%",Between4and5);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", Between3and4);
            Console.WriteLine("Fail: {0:f2}%",Fail);
            Console.WriteLine("Average: {0:f2}",AverageGrade);
        }
    }
}
