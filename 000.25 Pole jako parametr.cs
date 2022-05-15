using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        static int[] VytvorPole()
        {
            int[] pole = new int[10];
            Random dice = new Random();

            for (int i = 0; i < 10; i++)
            {
                pole[i] = dice.Next(1, 100);
            }

            return pole;
        }

        static void TiskPole(int[] pole)
        {
            for(int i = 0; i < pole.Length; i++)
            {
                if (i == 5)
                    Console.WriteLine();
                Console.Write("{0} \t", pole[i]);
                
            }
        }

        static void Main(string[] args)
        {
            /* Naprogramujte metodu VytvorPole(), která vrací pole 10 prvků obsahující náhodná čísla 1..99. 
             * Naprogramujte metodu TiskPole(int[]pole), která tiskne pole zadané jako parametr.
             */

            int[] a = VytvorPole();
            TiskPole(a);

            Console.ReadLine();
        }
    }
}
