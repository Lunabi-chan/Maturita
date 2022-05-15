using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Cyklem for načtěte matici typu m x n podle zadání uživatele a vytiskněte cyklem foreach.
             */

            Random dice = new Random();

            Console.Write("Zadej počet sloupců: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Zadej počet řádků: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int[,] pole = new int[b,a];

            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    pole[i, j] = dice.Next(0, 20);
                }
            }

            int c = 0;

            foreach(int p in pole)
            {
                if(c % a == 0)
                {
                    Console.WriteLine();
                }

                Console.Write("{0}\t", p);
                c++;
            }

            Console.ReadLine();
        }
    }
}
