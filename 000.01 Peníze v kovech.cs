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
        public static void Peníze(ref int x, ref int y)
        {
            
        }
        static void Main(string[] args)
        {
            /* Napište program, který pro zadanou sumu peněz (1–200 Kč) vytiskne výčetku českých kovových platidel potřebných k vyplacení zadané sumy. */

            string Choice = "Ano";
            int x = 0;
            int j = 0;
            var List = new List<int> { 50, 20, 10, 5, 2, 1, 0 };

            while (Choice == "Ano")
            {
                Console.Clear();
                

                Console.Write("Zadejte sumu peněz: ");
                x = int.Parse(Console.ReadLine());


                while (x != 0 || j != 6)
                {
                    if (x / List[j] == 0)
                    { 
                        j++;
                        continue; 
                    }
                    else if (x / List[j] != 0)
                    {
                        Console.WriteLine("\n Budete potřebovat {0} Kč {1}-krát.", List[j], x / List[j]);
                        x = x % List[j];
                        j++;
                    }

                    if (x == 0)
                        break;
                }

                Console.Write("\n\nChcete pokračovat? Napište Ano/Ne: ");
                Choice = Console.ReadLine();

                j = 0;
                
            }
        }
    }

}

