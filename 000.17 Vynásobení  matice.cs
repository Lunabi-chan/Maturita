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

        static int[,] VytvorMatici(int[,] mat, int číslo)
        {
            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] *= číslo;
                }
            }

            return mat;
        }

        static void Tisk(int[,] mat, int YesNo)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if(YesNo == 1)
                    {
                        mat[i, j] = dice.Next(1, 50);
                    }
                    Console.Write("{0}   \t", mat[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            /* Naprogramujte metodu VytvorMatici(int [,] mat, int císlo), která vynásobí matici číslem
             */

            int n = dice.Next(1, 10);

            int[,] mat = new int[dice.Next(1,10), dice.Next(1, 10)];

            Tisk(mat, 1);

            Console.WriteLine("\n\n");

            mat = VytvorMatici(mat, n);

            Tisk(mat, 0);

            Console.WriteLine("\n{0}, {1}, {2}", n, mat.GetLength(0), mat.GetLength(1));
            Console.ReadLine();

        }
    }
}
