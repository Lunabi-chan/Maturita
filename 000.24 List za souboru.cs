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
            /* Napište program, který zpracovává textový soubor celých čísel (každý řádek jedno číslo). 
             * Čísla načte do seznamu List<> a na obrazovku vypíše dvojnásobky kladných čísel a 
             * absolutní hodnoty všech nekladných čísel.
             */

            string cesta = @"C:\Users\MlpLu\OneDrive\Dokumenty\Do školy - 4.A\IVT\Testing for Visual studio\Něco kopie 2.txt";
            string aha;
            List<int> list = new List<int>();

            if (File.Exists(cesta))
            {
                using (StreamReader sr = new StreamReader(cesta))
                {
                    while ((aha = sr.ReadLine()) != null)
                    {
                        foreach (string p in aha.Split(' ', '\n'))
                        {
                            if (p != "")
                            {
                                list.Add(Convert.ToInt32(p));
                            }

                        }
                    }
                    sr.Close();
                }

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] > 0)
                    {
                        Console.WriteLine("{0}: \t{1}", list[i], list[i] * 2);
                    }
                    if (list[i] < 0)
                    {
                        Console.WriteLine("{0}: \t{1}", list[i], Math.Abs(list[i]));
                    }
                    if (list[i] == 0)
                    {
                        Console.WriteLine("{0}: \t{1}", list[i], list[i]);
                    }
                }
            }
            else
                Console.WriteLine("It not exist");

            Console.ReadLine();
        }
    }
}
