using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU
{
    public class Mage : Personnage
    {
        public Mage() /* création d'un Mage */
        {
            Random rand = new Random();
            PointsDeVie = rand.Next(10, 30);
            PointsDeForce = rand.Next(10, 20);
            PointsDagilite = rand.Next(10, 20);
            PointsDeMana = rand.Next(10, 20);
        }
    }
}
