using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        public static Random dice = new Random();

        static void Srovnání()
        {
            for (int i = 0; i < 11; i++)
            {
                if(i == 8)
                {
                    break;
                }

                if (i == 4)
                {
                    continue;
                }

                Console.WriteLine("{0,5}", i);
            }
        }

        static void MaticeN(int n, int m, int[,] mat)
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    mat[i, j] = dice.Next(1, 100);
                    Console.Write("{0, 5}", mat[i, j]);
                }
                Console.WriteLine();
            }

            if (m == n)
            {
                Console.WriteLine("Yes.");
            }
            else
                Console.WriteLine("No.");
        }

        static void Main(string[] args)
        {
            /* Napište program, na kterém předvedete v cyklu for srovnání příkazů break a continue.
             * Napište program, který načte matici řádu n (symbolická konstanta) zjistí, zda je symetrická. 
             * Hlavní metoda Main() bude obsahovat pouze volání metod.
             */

            int[,] matice = new int[3, dice.Next(2,6)];

            Srovnání();
            MaticeN(matice.GetLength(0), matice.GetLength(1), matice);

            Console.ReadLine();
        }
    }
}
