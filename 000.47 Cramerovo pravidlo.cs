using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        static int Determinant(int[,] mat)
        {
            int x = (mat[0,0] * mat[1, 1] * mat[2, 2] + mat[1, 0] * mat[2, 1] * mat[0, 2] + mat[2, 0] * mat[0, 1] * mat[1, 2]) 
                - (mat[0, 2] * mat[1, 1] * mat[2, 0] + mat[1, 2] * mat[2, 1] * mat[0, 0] + mat[2, 2] * mat[0, 1] * mat[1, 0]);

            return x;
        }

        static void Main(string[] args)
        {
            /* Sestavte algoritmus a napište program pro řešení soustavy tří rovnic o třech neznámých užitím Cramerova pravidla. 
                            x1 + 2x2 + 5x3 = –9
                            x1 –  x2 + 3x3 = 2
                           3x1 – 6x2 –  x3 = 25

                            3x1 – x2       = 5
                           –2x1 + x2 +  x3 = 0
                            2x1 – x2 + 4x3 = 15

             */

            int[,] A = new int[,]       { { 1,  2,  5 },
                                          { 1, -1,  3 },
                                          { 3, -6, -1 } };

            int[,] X = new int[,]       { { -9,  2,  5 },
                                          {  2, -1,  3 },
                                          { 25, -6, -1 } };

            int[,] Y = new int[,]       { { 1, -9,  5 },
                                          { 1,  2,  3 },
                                          { 3, 25, -1 } };

            int[,] Z = new int[,]       { { 1,  2, -9 },
                                          { 1, -1,  2 },
                                          { 3, -6, 25 } };

            int x = Determinant(X) / Determinant(A);
            int y = Determinant(Y) / Determinant(A);
            int z = Determinant(Z) / Determinant(A);

            Console.WriteLine($"x = {x}\ny = {y} \nz = {z}");

            
            
            A = new int[,]       { { 3,  -1,  0 },
                                          {  -2, 1,  1 },
                                          { 2, -1, 4 } };

            X = new int[,]       { { 5,  -1,  0 },
                                          {  0, 1,  1 },
                                          { 15, -1, 4 } };

            Y = new int[,]       { { 3,  5,  0 },
                                          {  -2, 0,  1 },
                                          { 2, 15, 4 } };

            Z = new int[,]       { { 3,  -1,  5 },
                                          {  -2, 1,  0 },
                                          { 2, -1, 15 } };

            x = Determinant(X) / Determinant(A);
            y = Determinant(Y) / Determinant(A);
            z = Determinant(Z) / Determinant(A);

            Console.WriteLine($"x = {x}\ny = {y} \nz = {z}");

            Console.ReadLine();
        }
    }
}
