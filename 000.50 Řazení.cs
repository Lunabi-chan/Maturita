using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        static bool HHH(int[] a, ref int[] b)
        {
            if (a.Length != b.Length)
            { return true; }

            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                { 
                    return true; 
                }

            }

            return false;
        }

        static void Tisk(int[] a)
        {
            for (int k = 0; k < a.Length; k++)
            {
                Console.Write("{0,5}", a[k]);
            }
            Console.WriteLine();
        }

        static void Výměna(ref int a, ref int b)
        {
            int pp;

            pp = a;
            a = b;
            b = pp;
        }

        static void Main(string[] args)
        {
            /* Napište program pro řazení jednorozměrného pole P celých čísel vzestupně
             * Použijte libovolný třídící algoritmus.
             */

            int[] pole = { 1, 2, 5, 10, 74, 8, 32, 17, 97, 13 };
            int[] pp = { 0 };
            int c = pole.Length - 1;

            do
            {
                pp = pole;

                for (int i = 0; i < pole.Length - 1; i++)
                {
                    if (pole[i] > pole[i + 1])
                    {
                        Výměna(ref pole[i], ref pole[i + 1]);
                    }
                    
                    for (int j = c; j >= 1; j--)
                    {
                        if (pole[j - 1] > pole[j])
                        {
                            Výměna(ref pole[j - 1], ref pole[j]);
                        }
                    }
                    
                }
                Tisk(pole);
            }
            while(HHH(pole, ref pp));

            Console.ReadLine();
        }
    }
}
