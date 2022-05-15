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
        static void Main(string[] args)
        {
            /*
             * Napište program, který přečte řetězec a vytiskne na samostatné řádky:
             * znak a jeho hodnotu v desítkové a šestnáctkové soustavě.
             */

            Console.Write("Řetězec: ");
            string věta = Console.ReadLine();

            foreach(char pp in věta)
            {
                Console.WriteLine(pp);
            }

            Console.ReadLine();
        }
    }

}

