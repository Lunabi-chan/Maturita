using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    public class Element
    {
        public int value;
        public Element p_next;
    }

    class Program
    {
        static void Biggest(Element POOP)
        {
            Element pp = new Element();
            int c = 0;
            pp.value = 0;

            while (POOP != null)
            {
                if (c < POOP.value || pp.value < POOP.value)
                {
                    c = POOP.value;
                    pp.value = POOP.value;
                }
                POOP = POOP.p_next;
            }

            Console.WriteLine("\nThe highest value in the list is: {0}, {1}", c, pp.value);
        }


        static void Main(string[] args)
        {
            /* Napište program, který 
                        a) vytvoří lineární spojový seznam obsahující 10 náhodně vygenerovaných celých čísel od 1 do 50 
                        b) naprogramujte metodu, která vytiskne největší hodnotu seznamu
             */

            Random dice = new Random();

            Element p_new = null;
            Element p_list = null;

            for (int i = 0; i < 10; i++)
            { 
                p_new = new Element() { value = dice.Next(1, 51), p_next = p_list};
                p_list = p_new;
            }

            int c = 0;

            Biggest(p_list);

            while (p_list != null)
            {
                if(c % 5 == 0)
                {
                    Console.WriteLine();
                }

                Console.Write("{0,5}", p_list.value);
                p_list = p_list.p_next;
                c++;
            }

            while (p_list != null)
            {
                if (c % 5 == 0)
                {
                    Console.WriteLine();
                }

                Console.Write("{0,5}", p_list.value);
                p_list = p_list.p_next;
                c++;
            }


            Console.ReadLine();
        }
    }
}
