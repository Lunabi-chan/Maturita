using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Vektory
    {
        private int x, y, z;

        // bezparametrický konstruktor
        public Vektory()
        {
            x = 1;
            y = 13;
            z = 7;
        }

        // parametrický konstruktor
        public Vektory(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void VelikostVektoru()
        {
            Console.WriteLine("The length of the vector is: {0}", Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2)));
        }

        public int NactiX()
        {
            return x;
        }

        public int NactiY()
        {
            return y;
        }

        public int NactiZ()
        {
            return z;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /* Naprogramovat třídu pro počítání s vektory v matematice:
                                                                            • tři souřadnice
                                                                            • konstruktor
                                                                            • metoda pro zjištění velikosti vektoru
                                                                            • vlastnosti
             */

            int x = 3, y = 5, z = 8;

            Vektory ugh = new Vektory(x, y, z);

            ugh.VelikostVektoru();

            Console.WriteLine("Vlastnosti: \n\tx: {0} \n\ty: {1} \n\tz: {2}", ugh.NactiX(), ugh.NactiY(), ugh.NactiZ());

            Console.ReadLine();
        }
    }
}
