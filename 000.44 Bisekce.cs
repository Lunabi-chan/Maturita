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
            return Math.Cos(x) - x;
        }

        static void Main(string[] args)
        {
            /* Sestavte algoritmus řešení rovnice f(x) = 0 metodou půlení intervalů. 
             * Přepište tento algoritmus jako program pro vyřešení rovnice: cos (x) – x = 0 (kořen leží v intervalu <0,1>)
             */

            // Interval <0;1>:
            double a = 0;
            double b = 1;

            // Přesnost si dáme třeba na 0.005
            double přesnost = 0.03;
            double c;
            double p;

            Console.WriteLine("a: f(a)\t\t\tb: f(b)\t\t\tc: f(c)");

            do
            {
                // Kořen se nachází v intervalu a naším úkolem je ho najít
                c = (a + b) / 2;
                p = (b - a) / 2;

                Console.WriteLine("{0}: {1:F4}\t\t{2}: {3:F4}\t\t{4}: {5:F4}", a, fce(a), b, fce(b), c, fce(c));

                if (fce(a) * fce(c) < 0)
                {
                    b = c;
                }
                else if (fce(b) * fce(c) < 0)
                {
                    a = c;
                }

            }
            while (p > přesnost);
            


            Console.ReadLine();
        }
    }
}
