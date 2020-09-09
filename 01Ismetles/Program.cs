using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Ismetles
{
    class Program
    {
        static void EredmenyKiiras(int gep, int ember)
        {
            switch (EmberNyer(gep,ember))
            {
                case 0:
                    Console.WriteLine("Döntetlen");
                    break;
                case 1:
                    Console.WriteLine("Skynet nyert!");
                    break;
                case 2:
                    Console.WriteLine("Ember nyert!");
                    break;
            }
        }
        static int EmberNyer(int gep, int ember)
        {
            if (ember == gep) // döntetlen
            {
                return 0;
            }
            else if (
                       (ember == 0 && gep == 1)
                         ||
                       (ember == 1 && gep == 2)
                         ||
                       (ember == 2 && gep == 0)
                     ) // gép nyer
            {
                return 1;
            }
            else //játékos nyer
            {
                return 2;
            }
        }

        static void Main(string[] args)
        {
            Random vel = new Random();
            string[] lehetoseg = new string[] {"kő", "papír", "olló"};

            int gepvalasz = vel.Next(0, 3);

            //Console.WriteLine("Gép választása: {0}", lehetoseg[gep]);

            int jatekosvalasz;

            Console.WriteLine("Kő {0}, Papír {1}, Olló {2}");
            Console.Write("Válasz: ");
            jatekosvalasz = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Játékos választása: {0}", lehetoseg[jatekosvalasz]);

            Console.WriteLine("Gép: {0} --- Játékos: {1}", lehetoseg[gepvalasz], lehetoseg[jatekosvalasz]);

            EredmenyKiiras(gepvalasz, jatekosvalasz);

            Console.ReadKey();
        }
    }
}
