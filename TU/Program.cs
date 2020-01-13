using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU
{
    class Program
    {
        static void Main(string[] args)
        {
             Personnage p1 = Personnage.choixPersonnage();
             Personnage p2 = Personnage.choixAdversaire();

        Console.WriteLine("\n\n Acceptez vous le tournoi contre cet adversaire ? --> 1 pour oui et 2 pour non");
            string tournoiAck = Console.ReadLine();
            switch (tournoiAck)
            {
                case "1":
                    Tournoi.accepterTournoi(p1, p2);
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Appuyez sur n'importe quel bouton pour quitter");
                    break;
                default:
                    Console.WriteLine("\n Vous n'avez pas rentré un des numéros demandés");
                    break;
            }
            Console.ReadKey();
        }
    }
}
