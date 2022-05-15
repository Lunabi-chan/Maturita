using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        static void Choice(string i)
        {
            int a = 2, b = 2, c = 1, d = 0, e = 4;
            int v = 0;

            switch (i)
            {
                case "a": v = a++ / ++c * --e; break;
                case "b": v = --b * c++ - a; break;
                case "c": v = -b - --c; break;
                case "d": v = ++a - --e; break;
                case "e": v = e / --a * b++ / c++; break;
                case "f": v = a %= (b = (d = 1 + e / 2)); break;
                case "g": Environment.Exit(0); break;
            }

            Console.WriteLine("Výsledek: {0}", v);
        }

        static void Main(string[] args)
        {
            /* Jsou-li dány definice: int a = 2, b = 2, c = 1, d = 0, e = 4; 
             * napište programy, které vypíší hodnoty následujících výrazů, 
             * a správnost zkontrolujte vlastním výpočtem.
                a) a++ / ++c * --e
                b) --b * c++ - a
                c) -b - --c
                d) ++a - --e
                e) e / --a * b++ / c++
                f) a %= b = d = 1 + e / 2
             */


            string choice = "h";

            while(choice != "g")
            {
                Console.Clear();

                Console.WriteLine("a) a++ / ++c * --e"
                + "\nb) --b* c++-a"
                + "\nc) -b - --c"
                + "\nd) ++a - --e"
                + "\ne) e / --a * b++ / c++"
                + "\nf) a %= b = d = 1 + e / 2" 
                + "\ng) Exit\n\n");

                Console.Write("Vaše volba: ");
                Choice(Console.ReadLine());

                Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}
