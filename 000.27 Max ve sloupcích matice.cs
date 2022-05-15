using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        static void Tisk(List<int> a)
        {
            for(int i = 0; i < a.Count; i++)
            {
                Console.Write("{0} ", a[i]);
            }

        }

        static void tisK(int[,] pole)
        {
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    Console.Write("{0}\t", pole[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            /* Je dána matice celých čísel 5tého řádu. Určete číslo sloupce s maximálním součtem všech prvků. 
             * Dosahuje-li se této maximální hodnoty součtu ve více sloupcích, vypište čísla všech takových sloupců.
             */

            int a = 5;
            Random dice = new Random();
            List<int> pp = new List<int> ();
            List<int> sloupce = new List<int> ();

            int[,] pole = new int[a, dice.Next(3,8)];

            for(int i = 0; i < a; i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    pole[i, j] = dice.Next(1, 100);
                }
            }

            for (int i = 0; i < pole.GetLength(1); i++)
            {
                pp.Add(0);
            }

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    pp[j] += pole[i, j];
                }
            }

            tisK(pole);

            int max = pp[0];

            for(int i = 1; i < pp.Count; i++)
            {
                if(max < pp[i])
                {
                    max = pp[i];
                }
            }

            for (int i = 0; i < pp.Count; i++)
            {
                if (max == pp[i])
                {
                    sloupce.Add(i);
                }
            }

            Console.Write("\nNejvětší součet sloupce v matici je: " + max + " a vyskytuje se ve sloupcích: "); Tisk(sloupce);
            Console.WriteLine(""); Tisk(pp);
            
            Console.ReadLine();
        }
    }
}
