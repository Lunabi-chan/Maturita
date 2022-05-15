using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        static double Doubly(double a, double b, double c,double d)
        {
            double x = a;

            if(b > x)
            {
                x = b;
            }
            if(c > x)
            {
                x = c;
            }
            if(d > x)
            {
                x = d;
            }

            return x;
        }

        static void Main(string[] args)
        {
            // Naprogramujte metodu se čtyřmi double parametry, která vrací největší z nich.

            Console.WriteLine(Doubly(13.5, 17.156, 0.124, 17.157));

            Console.ReadLine();
        }
    }
}
