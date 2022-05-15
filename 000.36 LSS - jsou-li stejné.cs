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
        public Element next;
    }

    class Program
    {
        static void AreTheyTheSame(Element list, Element tsil)
        {
            int t = 0;

            while (list != null)
            {
                if (list.value != tsil.value)
                {
                    Console.WriteLine("They aren't the same");
                    break;
                }
                else if(list.value == tsil.value)
                {
                    t++;
                }

                list = list.next;
                tsil = tsil.next;
            }

            if(t == 11)
            { Console.WriteLine("They are the same!\n"); }
            
        }

        static void Print(Element list)
        {
            while(list != null)
            {
                Console.Write("{0,5}", list.value);
                list = list.next;
            }
            Console.WriteLine("\n");
        }


        static void Main(string[] args)
        {
            /* Naprogramujte metodu, která má dva parametry, ukazatele na lineární spojové seznamy a zjistí, 
             * zda jsou tyto seznamy stejné, tzn. obsahují stejné prvky ve stejném pořadí.
             */

            Element list = null;
            Element tsil = null;

            Element kick = null;
            Element kcik = null;

            int p = 10;

            for (int i = 0; i < 11; i++)
            {
                list = new Element() { value = i, next = list };
                tsil = new Element() { value = i, next = tsil };
            }

            for (int i = 0; i < 11; i++)
            {
                kick = new Element() { value = i, next = kick };
                kcik = new Element() { value = p, next = kcik };

                p--;
            }

            Print(list);
            Print(tsil);

            AreTheyTheSame(list, tsil);

            Print(kick);
            Print(kcik);

            AreTheyTheSame(kick, kcik);

            Console.ReadLine();
        }
    }
}
