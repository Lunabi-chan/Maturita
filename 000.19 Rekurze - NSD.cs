using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        /* Sestavte algoritmus a napište program pro výpočet NSD(a,b) Euklidovým algoritmem pomocí rekurze.
         */

        static int NSD(int a, int b)
        {
            if (a == b)
                return a;
            if (a > b)
            {
                return NSD(a - b, b);
            }
            else
                return NSD(a, b - a);
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine(NSD(30, 200));


            Console.ReadLine();
        
        }
    }
}
