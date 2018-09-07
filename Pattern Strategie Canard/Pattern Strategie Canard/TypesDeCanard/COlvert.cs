using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Colvert : Canard
    {
       public Colvert ()
        {
            ComportementVol = new VolerAvecDesAiles();
            ComportementCancan = new Cancan();
        }
        

       public override void Afficher()
        {
            Console.WriteLine("Je suis un vrai Colvert");
        } 
    }
}
