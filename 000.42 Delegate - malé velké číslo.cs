using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp_1
{
    class Program
    {
        public static Random dice = new Random();

        public delegate void MV(int x);

        static void MalN(int x)
        {
            Console.WriteLine($"{x} - malé číslo");
        }

        static void velN(int x)
        {
            Console.WriteLine($"{x} - velké číslo");
        }

        static void Main(string[] args)
        {
            /* Program vygeneruje náhodné číslo <1, 99) a asociujte delegáta s metodou pro tisk malých čísel, je-li náhodné číslo menší než 50. 
             * Jinak asociujte delegáta s metodou pro tisk velkých čísel. Pozor na instanční třídu. Program využívá ternární operátor.
             */

            MV dell;

            int x = dice.Next(1, 100);

            dell = x < 50 ? new MV(MalN) : new MV(velN);
            dell(x);

            Console.ReadLine();   
        }
    }
}
