using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        static int Fibonacci(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            else
                return (Fibonacci(n - 1) + Fibonacci(n - 2));
        }

        static void Main(string[] args)
        {
            /* Napište metodu pro rekurzívní a nerekurzívní výpočet n-tého členu Fibonacciho posloupnosti.
             */

            int n = 8, a = 0, b = 1, c;


            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}\t", a);
                c = a;
                a += b;
                b = c;
            }

            Console.WriteLine("\n{0}", Fibonacci(n-1));

            Console.ReadLine();
        }
    }
}
