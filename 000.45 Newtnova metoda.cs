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
        { return Math.Cos(x) - x; }
        public static double Dfce(double x)
        { return - Math.Sin(x) - 1; }
        public static double DDfce(double x)
        { return Math.Cos(x); }

        static void Main(string[] args)
        {
            /* Sestavte algoritmus řešení rovnice f(x) = 0 Newtonovou metodou (metodou tečen). 
             * Přepište tento algoritmus jako program pro vyřešení rovnice: cos (x) – x = 0 (kořen leží v intervalu <0,1>).
             */

            double dol = 0, hor = 1, přes = 0.03, x, xs;

            if (fce(dol) * Dfce(dol) > 0)
            {
                x = dol;
            }
            else
                x = hor;

            do
            {
                xs = x;
                x = x - (fce(x)/Dfce(x));

                Console.WriteLine("x: " + x);
            }
            while (Math.Abs(x - xs) > přes);

            Console.ReadLine();
        }
    }
}
