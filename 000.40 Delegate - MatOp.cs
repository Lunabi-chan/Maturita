using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class MatOp
    {
        public static int Součet(int a, int b)
        {
            return a + b;
        }
        public static int Rozdíl(int a, int b)
        {
            return a - b;
        }
        public static int Součin(int a, int b)
        {
            return a * b;
        }
        public static int Podíl(int a, int b)
        {
            return a / b;
        }
    }

    class Program
    {
        public delegate int Dell(int a, int b);

        public static void UHOH(int a, int b, string name, Dell f)
        {
            Console.WriteLine($"{name}: {f(a, b)}");
        }

        static void Main(string[] args)
        {
            /* Vytvořte třídu MatOp.cs obsahující metody základních matematický operací: Součet, Rozdíl, Součin a Podíl. 
             * Metody mají signaturu předepsanou delegátem MatemOperace. 
             * Napište program, který vytiskne hodnoty všech operací pro vstupní hodnoty a, b.
             */

            int a = 8, b = 4;

            UHOH(a, b, "Součet", MatOp.Součet);
            UHOH(a, b, "Rozdíl", MatOp.Rozdíl);
            UHOH(a, b, "Součin", MatOp.Součin);
            if(b == 0)
            {
                Console.WriteLine("No");
            }
            else
                UHOH(a, b, "Podíl", MatOp.Podíl);


            Console.ReadLine();
        }
    }
}
