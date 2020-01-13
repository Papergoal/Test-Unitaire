using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU
{
    class Tournoi
    {
        public static void accepterTournoi(Personnage p1, Personnage p2)
        {
            while ((p1.PointsDeVie  > 0) || (p2.PointsDeVie > 0))
            {
                p1.PointsDeVie -= p2.PointsDeForce;
                Console.WriteLine(p1.NomDuPersonnage ,"se fait attaquer par ", p2.NomDuPersonnage);
                Console.WriteLine("Il reste ", p1.PointsDeVie, "points de vie à", p1.NomDuPersonnage);
            }
        }
        //accepterTournoi(IAttaquantArme un, IAttaquantArme deux);
        //accepterTournoi(IAttaquantMagie un, IAttaquantMagie deux);


    }
}
