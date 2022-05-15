using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    public class Prvek
    {
        public int hodnota;
        public Prvek p_next;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Vysvětli vytvoření spojového seznamu s prvky 2, 16, 22 a jeho tisk.

            Prvek p_new = null;
            Prvek p_list = null;

            // Vytvoření prvního prvku
            p_new = new Prvek() { hodnota = 2, p_next = null };
            /*p_new.hodnota = 2;
            p_new.p_next = null;*/
            p_list = p_new;

            // Vytvoření druhého prvku
            p_new = new Prvek() { hodnota = 16, p_next = null };
            /*p_new.hodnota = 16;
            p_new.p_next = null;*/
            p_list.p_next = p_new;

            // Vytvoření třetího prvku
            p_new = new Prvek() { hodnota = 22, p_next = null }; ;
            /*p_new.hodnota = 22;
            p_new.p_next = null;*/
            p_list.p_next.p_next = p_new;

            while(p_list != null)
            {
                Console.Write("{0,5}", p_list.hodnota);
                p_list = p_list.p_next;
            }

            Console.ReadLine();
        }
    }
}
