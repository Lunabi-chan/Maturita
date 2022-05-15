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
            /* Napište program, který na obrazovku vypíše všechna slova z textového souboru začínající na dané písmeno.
             */

            string cesta = @"C:\Users\MlpLu\OneDrive\Dokumenty\Do školy - 4.A\IVT\Testing for Visual studio\vstupAAA.txt";
            string a = "a";
            string věta;

            List<string> tt = new List<string>();

            if(File.Exists(cesta))
            {
                using(StreamReader sr = new StreamReader(cesta))
                {
                    while((věta = sr.ReadLine()) != null)
                    {
                        foreach(string s in věta.Split('\n', '\t', ' ', '.', ','))
                        {
                            if(s.ToLower().StartsWith(a))
                            {
                                tt.Add(s);
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < tt.Count; i++)
            {
                Console.WriteLine(tt[i]);
            }

            Console.ReadLine();
        }
    }
}
