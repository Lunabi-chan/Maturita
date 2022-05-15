using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Grandpapi
    {
        public string Oven { get; set; }

        public void OhYesDaddy()
        {
            Daddy DD = new Daddy();

            DD.value = 10;
            Console.WriteLine(DD.value);
        }
    }

    class Daddy : Grandpapi
    {
        public int value;

        public void Pain()
        {
            Grandpapi GP = new Grandpapi();

            GP.Oven = "AAA";
            Console.WriteLine(GP.Oven);
        }
    }

    class Son : Daddy
    {
        public void Pupu()
        {
            Grandpapi GP = new Grandpapi();

            GP.Oven = "BBB";
            Console.WriteLine(GP.Oven);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Naprogramovat vlastní třídu a ukázat na ní charakteristické vlastnosti tříd, ukázat bázovou a odvozenou třídu.


            Grandpapi a = new Grandpapi();
            Daddy b = new Daddy();
            Son c = new Son();

            a.OhYesDaddy();
            
            b.OhYesDaddy();
            b.Pain();
            
            c.Pain();
            c.Pupu();
            c.OhYesDaddy();

            Console.ReadLine();

        }
    }
}
