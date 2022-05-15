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
            /*Napište program, který vypíše přesně následující text:
             * James Bond \ "Agent 007" \ # 150% záruka # /
             * Spol. s ručením neomezeným
             */

            Console.Write(@"James Bond \ ");
            Console.Write("\"Agent 007\"");
            Console.Write(@" \ # 150% záruka # /");
            Console.WriteLine("\nSpol. s ručením neomezeným");
        }
    }

}

