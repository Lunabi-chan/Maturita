using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        static int fakt(int a)
        {
            if (a == 0)
                return 1;

            return a * fakt(a - 1);
        }

        static void Main(string[] args)
        {
            /* Sestavte algoritmus a napište program pro výpočet řady e^x:
             * e^x = součet(k = 0) x^k / k!
             */

            int x = 5;

            double e = 1;

            for (int k = 1; e < Math.Pow(Math.E, x); k++)
            {
                e += Math.Pow(x, k) / fakt(k);
            }


            Console.WriteLine(e);
            Console.ReadLine();
        }
    }
}
