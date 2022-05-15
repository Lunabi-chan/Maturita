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
            /* Sestavte algoritmus a napište program, který zjistí, zda se v poli A vyskytuje číslo X a vytiskne počet výskytů tohoto čísla nebo zprávu, že se číslo v poli nevyskytuje. 
             * Číslo X zadejte na vstupu.
             */

            Random dice = new Random();

            Console.Write("Číslo od 1 - 20: ");
            int a = int.Parse(Console.ReadLine());
            int n = 0;

            int[] A = new int[20];

            for (int i = 0; i < A.Length; i++)
            {
                if (i % 5 == 0)
                    Console.WriteLine();
                
                A[i] = dice.Next(1, 21);
                Console.Write($"{A[i],5}");

                if(A[i] == a)
                {
                    n++;
                }
            }

            Console.WriteLine();

            if(n == 0)
            {
                Console.WriteLine($"\nČíslo {a} se nevyskytuje v souboru");
            }
            else
                Console.WriteLine($"\nČíslo {a} se vyskytuje v souboru vyskytuje {n}-krát");

            Console.ReadLine();

        }
    }
}
