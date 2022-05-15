using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        static void Fuse(ref List<string> G, string g)
        {
            for(int i = 0; i < 2; i++)
            {
                G.Add(g.Split(' ')[i]);
            }
        }

        static double Vzdálenost(int a, int b, int c, int d)
        {
            if(a < 0 || c < 0)
            {
                a -= c;
            }
            else
            {
                a += c;
            }

            if (b < 0 || d < 0)
            {
                b -= d;
            }
            else
            {
                b += d;
            }

            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }

        static void Main(string[] args)
        {
            /* Naprogramujte metodu, která na základě kartézských souřadnic dvou bodů v rovině spočítá jejich vzdálenost. 
             * S pomocí této funkce vytvořte program, který ze vstupu přečte souřadnice vrcholů trojúhelníka v rovině a spočítá velikosti všech tří jeho stran.
             */

           /* List<int> čísla = new List<int>();

            Console.Write("Zadejte souřadnice prvního bodu (rozdělte mezerníkem): ");
            string a = Console.ReadLine();

            Console.Write("Zadejte souřadnice druhého bodu (rozdělte mezerníkem): ");
            string b = Console.ReadLine();

            List<string> A = new List<string> {  };

            Fuse(ref A, a);
            Fuse(ref A, b);

            foreach (string t in A)
            {
                čísla.Add(Convert.ToInt32(t));
            }

            Console.WriteLine();

            for (int i = 0; i < čísla.Count ;i++)
            {
                Console.Write("\n " + čísla[i]);
            }

            double p = Vzdálenost(čísla[0], čísla[1], čísla[2], čísla[3]);

            Console.WriteLine("\n\n Vzdálenost jest: " + p);

            Console.ReadLine();*/

            List<string> BEE = new List<string>();
            List<int> Bee = new List<int>();

            int choice = 0;
            while(choice != 3)
            {

                Console.Write("1: pro vzd 2 bodů\n2: pro vzd 3 bodů\n");
                Console.WriteLine("3: Exit");
                choice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                switch(choice)
                {
                    case 1: 
                        for (int i = 0; i < 2; i++) 
                        { 
                            Console.Write("2 body s mezerou: ");
                            string g = Console.ReadLine();
                            Fuse(ref BEE, g);
                        }

                        foreach(string a in BEE)
                        {
                            Bee.Add(Convert.ToInt32(a));
                        }

                        double q = Vzdálenost(Bee[0], Bee[1], Bee[2], Bee[3]);

                        Console.WriteLine("Vzdálenost mezi body je: {0}", q + " jednotek");
                        Console.WriteLine("\n\n");

                        break; 

                    case 2:
                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write("2 body s mezerou: ");
                            string g = Console.ReadLine();
                            Fuse(ref BEE, g);
                        }

                        for (int i = 0; i < BEE.Count; i++)
                        {
                            Bee.Add(Convert.ToInt32(BEE[i]));
                        }

                        Console.WriteLine("Vzdálenost mezi body |AB| je: {0}", Vzdálenost(Bee[0], Bee[1], Bee[2], Bee[3]) + " jednotek");
                        Console.WriteLine("Vzdálenost mezi body |AC| je: {0}", Vzdálenost(Bee[0], Bee[1], Bee[4], Bee[5]) + " jednotek");
                        Console.WriteLine("Vzdálenost mezi body |BC| je: {0}", Vzdálenost(Bee[2], Bee[3], Bee[4], Bee[5]) + " jednotek");
                        Console.WriteLine("\n\n");

                        break;

                    case 3: Environment.Exit(0); break;

                    default: Console.WriteLine("Špatně zadaná hodnota"); break;
                }
            }
        }
    }
}
