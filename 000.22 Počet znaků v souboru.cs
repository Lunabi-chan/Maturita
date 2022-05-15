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
            /* Spočítejte výskyt zadaného znaku ve vstupním souboru dopis.txt. Výskyt vyjádřete absolutním číslem i v procentech.
             */

            string cesta = @"C:\Users\MlpLu\OneDrive\Dokumenty\Do školy - 4.A\IVT\Testing for Visual studio\Něco kopie 3.txt";

            int PeePee;
            char k;
            double i = 0, n = 0;

            using (StreamReader sr = new StreamReader(cesta))
            {
                while((PeePee = sr.Read()) != -1)
                {
                

                    k = Convert.ToChar(PeePee);

                    if (k == '\n' || PeePee == 13)
                    {
                        continue;
                    }

                    if (k == 's')
                    {
                        i++;
                    }
                    
                    n++;
                }

                sr.Close();
            }

            /* 100 ... n
             *   x ... i
             *   
             *   x = i/n * 100
             */

            double x = (i / n) * 100;

            Console.WriteLine("Výskyt znaku s v souboru je {0} a to je {1:F2}%", i, x);

            Console.ReadLine();
        }
    }
}
