using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        public static double fce(double x)
        {
            return Math.Pow(x, 2) - (5 * x) + 13;
        }

        static void Main(string[] args)
        {
            /* Sestavte algoritmus a napište program pro výpočet určitého integrálu z funkce f(x) v intervalu <a, b> lichoběžníkovou metodou (Simpsonovou metodou). 
             * V programu použijte metodu f(x)=x2 – 5x + 13 v <1,3>.
             */

            double a = 1, b = 3, n = 10, x;
            double krok = (b - a) / n;
            double součet = 0;

            do 
            {
                x = a;
                a += krok;
                součet += ((a - x) / 6) * (fce(a) + 4 * fce((a + x) / 2) + fce(x));
            }
            while (a < b);

            Console.WriteLine(součet);
            Console.ReadLine();
        }
    }
}
