using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU
{
    public class Sac : Personnage
    {
        public Sac()
        {
        }

        public void AjoutSac()
        {
            Stack<string> nombres = new Stack<string>();
            nombres.Push("épée");
            nombres.Push("masse");
            nombres.Push("grimoire");
            nombres.Push("potion");
            nombres.Push("dent de gobelin");

            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }
            Console.WriteLine();
            Console.WriteLine("Cette liste plus haut contient les objets de votre sac.");
            Console.WriteLine();


        }



    }
}
