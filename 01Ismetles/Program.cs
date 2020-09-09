using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Ismetles
{
    class Program
    {
        static void Main(string[] args)
        {
            Random vel = new Random();
            string[] lehetoseg = new string[] {"kő", "papír", "olló"};

            int gepvalasz = vel.Next(0, 3);

            //Console.WriteLine("Gép választása: {0}", lehetoseg[gepvalasz]);

            int jatekosValasz;

            Console.WriteLine("Kő {0}, Papír {1}, Olló {2}");
            Console.Write("Válasz: ");
            jatekosValasz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Játékos választása: {0}", lehetoseg[jatekosValasz]);

            if (jatekosValasz == gepvalasz) // döntetlen
            {
                Console.WriteLine("Döntetlen!");
            }
            else if (
                       (jatekosValasz == 0 && gepvalasz == 1)
                         ||
                       (jatekosValasz == 1 && gepvalasz == 2)
                         ||
                       (jatekosValasz == 2 && gepvalasz == 0)
                     ) // gép nyer
            {
                Console.WriteLine("Gép nyert!");
            }
            else // játékos nyer
            {
                Console.WriteLine("Játékos nyert!");
            }

            Console.ReadKey();
        }
    }
}
