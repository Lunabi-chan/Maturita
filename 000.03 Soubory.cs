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
        static void Main(string[] args)
        {
            /*
             * Napište program, který zkopíruje obsah souboru stary.txt do souboru novy.txt. 
             * Navíc převede velká písmena na malá, vypustí číslice a místo mezer přejde vždy na nový řádek.
             */

            string cesta2 = @"C:\Users\MlpLu\OneDrive\Dokumenty\Do školy - 4.A\IVT\Testing for Visual studio\Něco.txt";
            string cesta = @"C:\Users\MlpLu\OneDrive\Dokumenty\Do školy - 4.A\IVT\Testing for Visual studio\Něco oof.txt";

            if (!File.Exists(cesta))
            {
                Console.WriteLine("Soubor neexistuje");
            }

            if (!File.Exists(cesta2))
            {
                Console.WriteLine("Soubor 2 neexistuje");
            }

            using (StreamWriter sw = new StreamWriter(cesta))
            {
                using (StreamReader sr = new StreamReader(cesta2))
                {
                    char Yes;

                    while((Yes = (char)sr.Read()) != -1)
                    {
                        if(Yes < 96 && Yes > 64)
                        {
                            Yes = (char)(Convert.ToInt32(Yes) + 32);
                        }
                        
                        if(Yes < 58 && 47 < Yes)
                        {
                            continue;
                        }

                        if(Yes == 32)
                        {
                            sw.WriteLine();
                            continue;
                        }

                        sw.Write(Yes);

                    }
                    sr.Close();
                }

                sw.Flush();
                sw.Flush();
            }

            Console.ReadLine();

        }
    }

}

