using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        static int fakt(int x)
        {
            if (x == 0)
            {
                return 1;
            }

            return x * fakt(x - 1);
        }

        static void Main(string[] args)
        {
            /* Sestavte algoritmus a napište program pro výpočet cos x z Taylorova rozvoje:
             * cos(x) = 1 - (x^2 / 2!) + (x^4 / 4!)) - (x^6 / 6!)) ...
             */

            double x = 70;
            double T = 1 - Math.Pow(x, 2) / fakt(2);
            int k = 2;

            double ugh = 1/2;
            double c = Math.Cos(ugh);

            while (T > c || -T < c)
            {
                T += Math.Pow(-1, k) * Math.Pow(ugh, 2 * k) / fakt(k * 2);
                k++;
            }
            Console.WriteLine($"{c}: {T,5}");

            Console.WriteLine($"{c}: {T,5}");
            Console.ReadLine();
        }
    }
}
