using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
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
            Console.WriteLine();
        }

        static void Součin(int[,] A, int[,] B)
        {       //               3 2       2 3
            
            int[,] C = new int[A.GetLength(0), B.GetLength(1)];

            for(int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    for (int k = 0; k < A.GetLength(1); k++)
                    { 
                        C[i, j] += A[i, k] * B[k, j]; 
                    }
                }
            }

            tisK(C);
        }

        static void Main(string[] args)
        {
            // Napište metodu pro součin matic.

            int[,] matice = new int[3,2];
            int[,] pole = new int[2,3];

            int a = 0;

            for (int i = 0; i < matice.GetLength(0); i++)
            {
                for (int j = 0; j < matice.GetLength(1); j++)
                {
                    a++;
                    matice[i, j] = a;
                }
            }

            a = 0;

            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    a++;
                    pole[i, j] = a;
                }
            }

            tisK(matice);
            tisK(pole);

            Console.WriteLine();
            Console.WriteLine();

            Součin(pole, matice);

            Console.ReadLine();
        }
    }
}
