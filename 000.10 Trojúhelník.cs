using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 
using System.Collections;

namespace ConsoleApp_1
{
    class Program
    {
        public static void Vyměň(ref int a, ref int b)
        {
            int pom = a;
            a = b;
            b = pom;
        }

        static void Main(string[] args)
        {
            int a = 4, b = 3, c = 5;
            int Choice = 0;

            while (Choice != 3)
            {
                Console.Clear();
                Console.Write("Zadej strany a: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Zadej strany b: ");
                b = int.Parse(Console.ReadLine());
                Console.Write("Zadej strany c: ");
                c = int.Parse(Console.ReadLine());

                if (c < a)
                {
                    Vyměň(ref c, ref a);
                }
                if (c < b)
                {
                    Vyměň(ref c, ref b);
                }

                double A = Math.Pow(a, 2);
                double B = Math.Pow(b, 2);
                double C = Math.Pow(c, 2);

                if ((a + b) >= c)
                {
                    Console.WriteLine("Je to trojúhelník.");
                    
                    if (C == (A + B))
                    {
                        Console.WriteLine("A je k tomu pravoúhlý.");
                    }
                }
                else
                    Console.WriteLine("Není to trojúhelník");

                Console.WriteLine("\n\nZnovu? Jestli ne tak zadej 3 a Enter");
                Console.ReadLine();
            }
        }
    }
}

