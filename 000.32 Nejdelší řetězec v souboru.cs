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
        static void Main(string[] args)
        {
            /* Napište program, který načítá na vstupu slova = textové řetězce (max. délky 50 znaků), ukládá je do textového souboru. 
             * Po vytvoření souboru najde nejdelší řetězec a vypíše jej na obrazovku i s jeho délkou.
             */

            Console.Write("Kolik řetězců chcete napsat? (Max. délka 50 znaků): ");
            int n = Convert.ToInt32(Console.ReadLine());

            string cesta = @"C:\Users\MlpLu\OneDrive\Dokumenty\Do školy - 4.A\IVT\Testing for Visual studio\vstupAAA.txt";
            string k;
            int u = 0, most = 0, ind = 0;

            List<string> a = new List<string>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Zadejte řetězec: ");
                k = Console.ReadLine();

                foreach (char l in k)
                {
                    u++;
                }
                
                if(u > 50)
                {
                    Console.WriteLine("\nŘetězec přesáhl maximum (50). Zadejte znovu.\n");
                    i--;
                }
                else
                    a.Add(k);

                u = 0;
            }

            if (File.Exists(cesta))
            {
                Console.WriteLine("\nIt exists!");

                using (StreamWriter sw = new StreamWriter(cesta))
                {
                    for (int i = 0; i < n; i++)
                    {
                        sw.WriteLine(a[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("It doesn't!! Also the console is going down after enter.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            for (int i = 0; i < n; i++)
            {
                foreach (char l in a[i])
                {
                    u++;
                }

                if (most < u)
                {
                    most = u;
                    ind = i;
                }

                u = 0;
            }

            Console.WriteLine("\nNejdelší řetězec s délkou {0} je: {1}", most, a[ind]);

            Console.ReadLine();
        }
    }
}
