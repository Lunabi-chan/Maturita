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
            /* Napište program, který načítá na vstupu velká písmena a tiskne malá písmena, 
             * dokud nebude stisknuto malé nebo velké q.
             */

            string Choice = "Ano";
            int C;
            char Peepeepoopoo = 'h';

            while (Peepeepoopoo != 'q' || Peepeepoopoo != 'Q')
            {
                Console.Write("\nZadejte písmeno: ");
                Choice = Console.ReadLine();

                foreach (char c in Choice)
                {
                    C = System.Convert.ToInt32(c);

                    if (65 > C || (C > 90 && C < 97) || C > 122)
                    {
                        Console.WriteLine("Hodnota je špatně zadaná!");
                        continue;
                    }

                    if (C > 64 && C < 91)
                    { C += 32; }
                    else //if (C > 96 && C < 123)
                    { C = C - 32; }

                    Console.Write(System.Convert.ToChar(C));

                    Peepeepoopoo = System.Convert.ToChar(C);

                    if (Peepeepoopoo == 'Q' || Peepeepoopoo == 'q')
                        Environment.Exit(0);
                }

                


                Console.ReadKey();
            }

        }
    }

}

