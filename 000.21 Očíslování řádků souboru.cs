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
        static void DoItBeExisting(string a)
        {
            Console.WriteLine(File.Exists(a) ? "Yay" : "Nay");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            /* Napište program, který vytvoří kopii souboru, ve které očísluje jednotlivé řádky.
             */

            string cesta = @"C:\Users\MlpLu\OneDrive\Dokumenty\Do školy - 4.A\IVT\Testing for Visual studio\Něco.txt";
            string cesta2 = @"C:\Users\MlpLu\OneDrive\Dokumenty\Do školy - 4.A\IVT\Testing for Visual studio\Něco ooftie.txt";

            string q;
            int n = 0;

            DoItBeExisting(cesta);
            DoItBeExisting(cesta2);

            using (StreamWriter sw = new StreamWriter(cesta2))
            {
                using (StreamReader sr = new StreamReader(cesta))
                {
                    while((q = sr.ReadLine()) != null)
                    {
                        if (q == "")
                        {
                            sw.WriteLine();
                            continue;
                        }

                        n++;
                        sw.Write("{0}. ", n);
                        sw.WriteLine(q);
                    }

                    sr.Close();
                }

                sw.Flush();
                sw.Close();
            }

            Console.ReadLine();
        }
    }
}
