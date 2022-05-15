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
        public static void Ano(int a)
        {
            Console.WriteLine(" Ano, číslo {0} je prvočíslo", a);
        }
        public static void Ne(int a)
        {
            Console.WriteLine(" Ne, číslo {0} není prvočíslo", a);
        }
       
        public static void Prvočíslo(int a)
        {
            if (a == 2)
            {
                Ano(a);
            }
            else if (a % 2 == 0)
            {
                Ne(a);
            }
            else
            {
                int x = 0;

                double k = Math.Sqrt(a);
                for (int i = 2; i < k; i++)
                {
                    if (a % i == 0)
                    {
                        x++;
                    }
                }

                if (x > 0)
                    Ne(a);
                if (x == 0) 
                    Ano(a);
            }
        }
        public static void Choice1()
        {
            Console.Write("\n\n Zadejte číslo: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Prvočíslo(a);
        }
        public static void Choice2()
        {
            string cesta = @"C:\Users\xduongova\source\repos\ConsoleApp1\Doplňky\Prvočísla.txt";
            try
            {
                using (var SR = new StreamReader(cesta))
                {
                    string line;
                    while ((line = SR.ReadLine()) != null)
                    {
                        var a = line;
                        var b = a.Split('\n', '\t', ' ');

                        for (int i = 0; i < b.Length; i++)
                        {
                            Prvočíslo(int.Parse(b[i]));
                        }
                    }
                }

                
            }
            catch (Exception e)
            {
                Console.WriteLine("\nSoubor nemohl být přečten: ");
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            /* Napište metodu, která zjišťuje, zda je dané přirozené číslo prvočíslo. S pomocí této funkce napište program, který
                        • čte na vstupu číslo a tiskne, zda je nebo není prvočíslo
                        • čte ze souboru posloupnost přirozených čísel a vypisuje prvočísla.
             */

            int Choice = 0;
            while (Choice != 3)
            {
                Console.Clear();

                Console.WriteLine("\n\tJak chcete zadat hodnotu/hodnoty?");
                Console.WriteLine("1.) Chci zadat jedno číslo (zadejte bez mezer)" + "\n2.) Mám soubor, ze kterého chci získat prvočísla" + "\n3.) Chci zavřít program");
                Console.Write("\n Zadejte číslo možnosti: ");
                Choice = int.Parse(Console.ReadLine());

                switch(Choice)
                {
                    case 1: Choice1();
                        break;
                    case 2: Choice2();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }

                Console.ReadLine();
            }
        }
    }

}

