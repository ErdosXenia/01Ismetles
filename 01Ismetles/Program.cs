using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Ismetles
{
    class Program
    {
        static string[] lehetoseg = new string[] { "kő", "papír", "olló" };

        static int gepnyer = 0;
        static int jatekosnyer = 0;
        static int jatekmenet = 0;

        static int GepValasztas()
        {
            Random vel = new Random();

            return vel.Next(0, 3);
        }
        static int JatekosValasztas()
        {
            Console.WriteLine("Kő {0}, Papír {1}, Olló {2}");

            Console.Write("Válasz: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void EredmenyKiiras(int gep, int ember)
        {
            Console.WriteLine("Gép: {0} --- Játékos: {1}", lehetoseg[gep], lehetoseg[ember]);

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
                gepnyer++;
                return 1;
            }
            else //játékos nyer
            {
                jatekosnyer++;
                return 2;
            }
        }
        private static bool AkarJatszani()
        {
            Console.WriteLine("------------------------------");
            Console.Write("Tovább? [i/n]: ");
            string valasz = Console.ReadLine().ToLower();
            Console.WriteLine("\n------------------------------");

            if (valasz == "i")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void Statisztikakiiras()
        {
            Console.WriteLine("Menetek száma: {0}" +
                "\t Játekos győzelmének száma: {1}" +
                "\t Gép győzelmének száma: {2}", jatekmenet, jatekosnyer, gepnyer);
        }
        static void Main(string[] args)
        {
            bool tovabb = true;

            while (tovabb)
            {
                jatekmenet++;

                int gepvalasz = GepValasztas();

                int jatekosvalasz = JatekosValasztas();

                EredmenyKiiras(gepvalasz, jatekosvalasz);

                tovabb = AkarJatszani();
            }

            Statisztikakiiras();

            Console.ReadKey();
        }

       
    }
}
