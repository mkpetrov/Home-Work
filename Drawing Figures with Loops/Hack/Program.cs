using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hack
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static string magicString(string text,int repearCount)
        {
            string OutputText = "";
            for (int i = 0; i < repearCount; i++)
            {
                OutputText = OutputText + text;
            }

            return OutputText;
        }
    }
}
