using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        static int Faktorial(int n)
        {
            Console.Write("{0}\t", n);

            if(n == 1)
            { return 1; }

            return n * Faktorial(n - 1);
        }

        static void Main(string[] args)
        {
            /* Sestavte algoritmus a napište program pro výpočet faktoriálu pomocí rekurze.
             */

            Console.Write("Hodnota: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Faktorial z {0} je {1}", n, Faktorial(n));

            Console.ReadLine();
        }
    }
}
