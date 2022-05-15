using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        static void maximum(int[,] pole, int a, int max, int min)
        {
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    if (max < pole[i, j])
                    {
                        max = pole[i, j];
                    }
                    if (min > pole[i, j])
                    {
                        min = pole[i, j];
                    }
                }
            }

            Console.WriteLine("\nMax: {0} \t\tMin: {1}", max, min);
        }

        static void Main(string[] args)
        {
            /* a) Napište program, který vytiskne maximální i minimální prvek matice a jeho indexy. 
             * b) Naprogramujte metodu maximum, která má 4 parametry: matici, řád matice, max, min. 
             *      Napište program, který pomocí metody maximum zjistí maximální a minimální prvek matice 
             *      a vytiskne jejich hodnoty.
             */

            Random dice = new Random();

            int[,] pole = new int[dice.Next(2,5),dice.Next(2,5)];

            for(int i = 0; i < pole.GetLength(0); i++)
            {
                for(int j = 0; j < pole.GetLength(1); j++)
                {
                    pole[i, j] = dice.Next(1, 100);
                    Console.Write("{0}\t", pole[i,j]);
                }
                Console.WriteLine();
            }

            int max = pole[0, 0];
            int a = 0, b = 0, c = 0, d = 0;
            int min = pole[0, 0];

            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    if(max < pole[i, j])
                    {
                        max = pole[i, j];
                        a = i;
                        b = j;
                    }
                    if (min > pole[i, j])
                    {
                        min = pole[i, j];
                        c = i;
                        d = j;
                    }
                }
            }

            Console.WriteLine("\nMax: pole[{0}, {1}]: {2} \tMin: pole[{3}, {4}]: {5}", a + 1, b + 1, max, c + 1, d + 1, min);

            maximum(pole, pole.GetLength(0), max, min);
            
            Console.ReadLine();
            

        }
    }
}
