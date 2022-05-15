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
            /* Napište program, který na vstupu načte pět řetězců (jmen) a uloží je do pole. 
             * Pole vytiskne v obráceném pořadí.
             */

            string[] pole = new string[5];

            for(int i = 1; i < 6; i++)
            {
                Console.Write($"Zadej {i}. jméno: ");
                pole[i-1] = Console.ReadLine();
            }

            for(int j = 4; -1 < j; j--)
            {
                Console.Write("{0}\t", pole[j]);
            }

            Console.ReadLine();

        }
    }
}
