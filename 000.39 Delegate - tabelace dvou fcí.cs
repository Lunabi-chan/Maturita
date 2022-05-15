using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        public delegate double Dell(double x);

        public static double fce1(double x)
        { return (Math.Pow(x, 2) + 8); }

        public static double fce2(double x)
        { return (Math.Pow(x, 3) - 3); }

        public static void Tabelace(double dol, double hor, double krok, Dell f)
        {
            for (double i = dol; i <= hor; i += krok)
            {
                Console.WriteLine("{0:F1}: {1:F2}", i, f(i));
            }
        }

        static void Main(string[] args)
        {
            /* Napište program pro tabelaci dvou funkcí x2 + 8 a x3 – 3, v intervalu <-1; 1> 
             * s krokem 0,2. Pak navrhněte metodu Tabelace a použijte delegate jako parametr.
             */

            int a = -1, b = 1;
            double krok = 0.2;

            Console.Write("1 nebo 2? : ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: Tabelace(a, b, krok, fce1); break;
                case 2: Tabelace(a, b, krok, fce2); break;
                default: Console.WriteLine("Oof"); break;
            }

            Console.ReadLine();


        }
    }
}
