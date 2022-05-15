using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace ConsoleApp_1
{
    class Program
    {
        static void Color(int i)
        {
            switch(i)
            {
                case 1: Console.ForegroundColor = ConsoleColor.Red; break;
                case 2: Console.ForegroundColor = ConsoleColor.Yellow; break;
                case 3: Console.ForegroundColor = ConsoleColor.Green; break;
                case 4: Console.ForegroundColor = ConsoleColor.Blue; break;
                case 5: Console.ForegroundColor = ConsoleColor.Magenta; break;
                case 6: Console.ForegroundColor = ConsoleColor.Cyan; break;
                case 7: Console.ForegroundColor = ConsoleColor.Gray; break;
                case 8: Console.ForegroundColor = ConsoleColor.White; break;
            }
        }

        static void Main(string[] args)
        {
            //Napište program, který zobrazuje v konzolovém okně vlastních rozměrů
            //na náhodných místech různě barevné hvězdičky.

            Random Dice = new Random();

            Console.WindowWidth = Dice.Next(10, 256);
            Console.WindowHeight = Dice.Next(10, 67);

            int color;
            int limit = Dice.Next(20, 30);
            int space;
            int x, y;

            for (int i = 0; i < limit; i++)
            {
                space = Dice.Next(1, 200);

                for (int j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }

                color = Dice.Next(0, 10);
                Color(color);

                Console.Write("*");

                Thread.Sleep(100);
            }


            Console.ReadLine();



        }
    }
}
