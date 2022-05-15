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
            /* Napište program, který zjistí, zda se v textovém souboru vyskytuje slovo 
                                            • PES 
                                            • a kolikrát slovo začínající i končící stejným znakem
             */

            string cesta = @"C:\Users\MlpLu\OneDrive\Dokumenty\Do školy - 4.A\IVT\Testing for Visual studio\test kopie.txt";

            if(File.Exists(cesta))
            {
                using(StreamReader sr = new StreamReader(cesta))
                {
                    string a;
                    int k = 0;
                    string h, r = "";
                    int f = 0;

                    while((a = sr.ReadLine()) != null)
                    {
                        foreach(string p in a.Split('\t', '\n', ' '))
                        {
                            h = p.ToLower();
                            if(h == "pes")
                            {
                                k++;
                            }

                            if (h != "\t" || h != "\n" || h != " " || h != "")
                            {
                                foreach (char t in h)
                                {
                                    r = Convert.ToString(t);
                                }

                                if (h.StartsWith(r))
                                {
                                    f++;
                                }

                            }
                        }
                    }
                    
                    Console.WriteLine($"PES se vyskytuje {k}-krát a slovo začínající a končící stejným písmenem {f}-krát");
                    sr.Close();
                }
            }

            Console.ReadLine();
        }
    }
}
