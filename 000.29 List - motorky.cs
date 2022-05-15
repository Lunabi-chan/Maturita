using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        static void Tisk(List<string> m)
        {
            foreach(string a in m)
            {
                Console.Write("{0}       \t", a);
            }
        }

        static void Main(string[] args)
        {
            /* Napište program, který: 
                                    • Vytvoří indexovaný seznam obsahující následující značky motocyklů: Jawa, Honda, Ducati, Kawasaki, Suzuki, BMW, Yamaha.
                                    • Vypíše seznam cyklem foreach.
                                    • Vytiskne počet prvků seznamu a pro kolik prvků je připraveno místo v paměti.
                                    • Vytiskne index motocyklu Suzuki.
                                    • Zruší motocykl BMV.
                                    • Vytiskne, zda je v seznamu motocykl značky Honda.
                                    • Nahradí motocykl Ducati motocyklem Indian.
                                    • Vytiskne seřazený seznam.
             */

            List<string> motorky = new List<string> { "Jawa", "Honda", "Ducati", "Kawasaki", "Suzuki", "BMW", "Yamaha" };

            int choice = 0;

            while(choice != -1)
            {
                Console.WriteLine("\n1: Foreach" +
                    "\n2: Vytiskne počet prvků + místo v paměti" +
                    "\n3: Index pro Suzuki" +
                    "\n4: No no BMV" +
                    "\n5: Je zde Honda?" +
                    "\n6: Indian na místo Ducati" +
                    "\n7: Vytiskne seřazený seznam" +
                    "\n8: Reset list do původního stavu" +
                    "\n9: Exit");

                Console.Write("\n Your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1: 
                        Tisk(motorky); 
                        break;
                    case 2:
                        Console.WriteLine("Počet prvků: {0} a kapacita: {1}", motorky.Count, motorky.Capacity);
                        break;
                    case 3:
                        Console.WriteLine("Index pro Suzuki v listu je: {0}", motorky.IndexOf("Suzuki"));
                        break;
                    case 4:
                        motorky.Remove("BMW");
                        Tisk(motorky);
                        break;
                    case 5:
                        if (motorky.Contains("Honda"))
                        {
                            Console.WriteLine("Yes.");
                        }
                        else
                            Console.WriteLine("No.");
                        break;
                    case 6:
                        int c = motorky.IndexOf("Ducati");
                        motorky.Remove("Ducati");
                        motorky.Insert(c, "Indian");
                        break;
                    case 7: 
                        motorky.Sort();
                        Tisk(motorky);
                        break;
                    case 8: 
                        motorky = new List<string> { "Jawa", "Honda", "Ducati", "Kawasaki", "Suzuki", "BMW", "Yamaha" };
                        break;
                    case 9:
                        Environment.Exit(0);
                        break;
                    default: break;
                }

                Console.ReadLine();

            }

        }
    }
}
