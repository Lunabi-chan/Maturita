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
        public static double E()
        { }

        static void Main(string[] args)
        {
            int Choice = 0;

            while(Choice != 1)
            {
                Console.Write("Zadejte počet km: ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("Cena: ");
                if (a <= 3 && a >= 1)
                {
                    Console.WriteLine("15Kč");
                }
                if (a <= 5 && a >= 4)
                {
                    Console.WriteLine("16 Kč");
                }
                if (a <= 7 && a >= 6)
                {
                    Console.WriteLine("11 Kč");
                }
                if (a >= 8)
                {
                    Console.WriteLine("10 Kč");
                }
                if (a < 1)
                    Console.WriteLine("Idk bro");

            }
        }
    }

}

