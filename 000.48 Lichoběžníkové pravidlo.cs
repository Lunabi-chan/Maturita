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
            return Math.Sin(x);
        }


        static void Main(string[] args)
        {
            /* Sestavte algoritmus a napište program pro výpočet určitého integrálu složeným lichoběžníkovým pravidlem: funkce sin(x) v intervalu <0; pí>.
            */

            double a = 0, b = Math.PI, n = 10, x;

            double interval = (b - a) / n;
            double součet = 0;

            do
            {
                x = a;
                a += interval;

                součet += (fce(a) + fce(x)) * (a - x) / 2;
            }
            while (a < b);

            Console.WriteLine(součet);
            Console.ReadLine();
        }
    }
}
