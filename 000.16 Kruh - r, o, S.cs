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
        static void Kruh(double r, ref double o, ref double S)
        {
            o = 2 * Math.PI * r;
            S = Math.PI * Math.Pow(r, 2);
        }

        static void Main(string[] args)
        {
            /* Naprogramujte metodu kruh se třemi parametry: polomer – vstupní parametr, obvod a obsah – výstupní parametry. 
             * Napište s využitím metody kruh program, který ze vstupního souboru čte reálná čísla = poloměry a 
             * tiskne přehlednout tabulku se sloupci poloměr, obsah a obvod kruhu. 
             */

            int choice = 0;
            List<double> N = new List<double>();
            List<double> P = new List<double>();
            Random dice = new Random();
            double o = 0, S = 0;
            string ugh;

            string cesta = @"C:\Users\MlpLu\OneDrive\Dokumenty\Do školy - 4.A\IVT\Testing for Visual studio\Něco kopie 2.txt";

            using (StreamReader sw = new StreamReader(cesta))
            {
                while((ugh = sw.ReadLine()) != null)
                {
                    foreach(string e in ugh.Split(' '))
                    {
                        P.Add(Convert.ToInt32(e));
                    }
                }

                sw.Close();
            }

            for (int i = 0; i < P.Count; i++)
            {
                Kruh(P[i], ref o, ref S);

                Console.WriteLine("Poloměr: {0}       \tObsah: {1:F2}       \tObvod: {2:F2}", P[i], S, o);
            }

            /*
            while (choice != -1)
            {
                Console.WriteLine("1: Pokračovat\n2: Konec\n");
                choice = Convert.ToInt32(Console.ReadLine());

                Console.Write("Kolik poloměrů checte?: ");
                int n = Convert.ToInt32(Console.ReadLine());

                for(int i = 0; i < n; i++)
                {
                    N.Add(dice.Next(1, 20));

                    Kruh(N[i], ref o, ref S);

                    Console.WriteLine("Poloměr: {0}  \tObsah: {1} \tObvod: {2}", N[0], S, o);
                }
            }*/

            Console.ReadLine();
        }
    }
}
