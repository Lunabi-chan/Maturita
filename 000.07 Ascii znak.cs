using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napište program, který přečte řetězec a vytiskne na samostatné řádky:
            //znak a jeho hodnotu v desítkové a šestnáctkové soustavě.

            Console.WriteLine("Karararraa");
            string a = "Karararraa";

            foreach(char i in a)
            {
                Console.WriteLine("{0} . . . {1}", i, Convert.ToInt32(i));
            }

            Console.ReadLine();
        }
    }
}
