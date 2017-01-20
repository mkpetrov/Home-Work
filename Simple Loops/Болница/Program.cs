using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Болница
{
    class Program
    {
        static void Main(string[] args)
        {
            int Period = int.Parse(Console.ReadLine());
            int Doctors = 7;
            int TreatedPatients = 0;
            int UntreatedPatients = 0;
            for (int i = 1; i <= Period; i++)
            {
                int Patient = int.Parse(Console.ReadLine());
                if (i % 3 == 0 && TreatedPatients < UntreatedPatients)
                {
                    Doctors++;
                }
                if (Doctors>=Patient)
                {
                    TreatedPatients += Patient;
                }
                else
                {
                    TreatedPatients += Doctors;
                    UntreatedPatients += (Patient - Doctors);
                }
                
            }
            Console.WriteLine("Treated patients: {0}.",TreatedPatients);
            Console.WriteLine("Untreated patients: {0}.",UntreatedPatients);
        }
    }
}
