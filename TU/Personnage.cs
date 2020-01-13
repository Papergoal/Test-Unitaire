using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU
{
    public class Personnage
    {
        public string NomDuPersonnage { get; set; }
        public int PointsDeVie { get; set; }
        public int PointsDagilite { get; set; }
        public int PointsDeForce { get; set; }
        public int PointsDeMana { get; set; }
        public  Personnage joueur { get; set; }
        public Personnage joueur2 { get; set; }


        public Personnage()
        {

        }
        public void afficherStats() /* méthode affichant les stats */
        {
            Console.WriteLine("Points de vie    : " + PointsDeVie);
            Console.WriteLine("Points de force  : " + PointsDeForce);
            Console.WriteLine("Points d'agilité : " + PointsDagilite);
            Console.WriteLine("Points de mana   : " + PointsDeMana);
        }

        public void afficherNom()
        {
            Console.WriteLine("Nom du personnage : " + this.NomDuPersonnage);
        }

        public static Personnage choixPersonnage()
        { 
            Personnage joueur = new Personnage();
            Console.Write("Entrez un nom de personnage que vous incarnerez: ");
            joueur.NomDuPersonnage = Console.ReadLine();
            Console.WriteLine("Tapez 1 pour incarner un guerrier, 2 pour un mage, 3 pour un chaman, 4 pour un voleur");
            string choixPerso = Console.ReadLine();
            switch(choixPerso)
            {
                    case "1":
                        Console.WriteLine("Vous devenez un Guerrier participant au tournoi :");
                        joueur = new Guerrier();
                        joueur.afficherStats();
                        break;

                    case "2":
                        Console.WriteLine("Vous devenez un Mage participant au tournoi :");
                        joueur = new Mage();
                        joueur.afficherStats();
                        break;

                    case "3":
                        Console.WriteLine("Vous devenez un Chaman participant au tournoi :");
                        joueur = new Chaman();
                        joueur.afficherStats();
                        break;

                    case "4":
                        Console.WriteLine("Vous devenez un Voleur participant au tournoi :");
                        joueur = new Voleur();
                        joueur.afficherStats();
                        break;
            }
            return joueur;
        }

        public static Personnage choixAdversaire()
        {
            Personnage joueur2 = new Personnage();
            Console.Write("Entrez un nom de personnage vous affrontant : ");
            joueur2.NomDuPersonnage = Console.ReadLine();
            Console.WriteLine("Tapez 1 pour affronter un guerrier, 2 pour un mage, 3 pour un chaman, 4 pour un voleur");
            string choixPerso = Console.ReadLine();
            switch (choixPerso)
            {
                case "1":
                    Console.WriteLine("Création d'un Guerrier participant au tournoi :");
                    joueur2 = new Guerrier();
                    joueur2.afficherStats();
                    break;

                case "2":
                    Console.WriteLine("Création d'un Mage participant au tournoi :");
                    joueur2 = new Mage();
                    joueur2.afficherStats();
                    break;

                case "3":
                    Console.WriteLine("Création d'un Chaman participant au tournoi :");
                    joueur2 = new Chaman();
                    joueur2.afficherStats();
                    break;

                case "4":
                    Console.WriteLine("Création d'un Voleur participant au tournoi :");
                    joueur2 = new Voleur();
                    joueur2.afficherStats();
                    break;
            }
            return joueur2;
        }

    }
}
