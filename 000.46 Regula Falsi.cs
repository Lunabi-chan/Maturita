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
            return Math.Pow((x / 2), 2) - Math.Sin(x);
        }

        static void Main(string[] args)
        {
            /* Sestavte algoritmus řešení rovnice f(x) = 0 metodou Regula falsi. 
             * Přepište tento algoritmus jako program pro vyřešení rovnice:
             * (x/2)^2 − sin x = 0 (kořen leží v intervalu <1.5, 2>)
             */

            double a = 1.5, b = 2, přes = 0.3, xs, x = 0;


            do
            {
                Console.WriteLine("{0:F4}: {1:F8}\t\t{2}: {3:F8}", a, fce(a), b, fce(b));

                xs = x;
                x = a - (fce(a) * ((b - a) / (fce(b) - fce(a))));

                if (fce(a) * fce(x) <= 0)
                    b = x;
                else
                    a = x;
            }
            while (Math.Abs(xs - x) > přes);

            Console.WriteLine(x);

            Console.ReadLine();
        }
    }
}
