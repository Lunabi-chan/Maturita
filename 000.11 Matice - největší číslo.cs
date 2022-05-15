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
        /* Na vstupu je dána posloupnost celých čísel zakončená číslem nula. 
         * Vytiskněte největší číslo a kolikrát se v posloupnosti vyskytuje.
         */

        static void Main(string[] args)
        {
            int nononumber = 1;
            List<int> oof = new List<int>();
            int i = 0;

            Console.WriteLine("Zadejte po řádcích celá čísla. Nulou ukončíte posloupnost.");

            while (nononumber != 0)
            {
                Console.Write("Zadejte: ");
                oof.Add(Convert.ToInt32(Console.ReadLine()));

                nononumber = oof[i];

                i++;
            }
            
            i = 0;

            for (int j = 0; j < (oof.Count - 1); j++)
            {
                if (oof[j] > nononumber)
                {
                    nononumber = oof[j];
                }
            }

            for (int j = 0; j < (oof.Count - 1); j++)
            {
                if (oof[j] == nononumber)
                {
                    i++;
                }
            }

            Console.WriteLine("\n Největší číslo je {0} a v posloupnosti se vyskytuje {1}-krát", nononumber, i);

            Console.ReadLine();
        }
    }

}

