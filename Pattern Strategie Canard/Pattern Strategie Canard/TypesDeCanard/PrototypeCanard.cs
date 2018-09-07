using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class PrototypeCanard : Canard
    {
        public PrototypeCanard()
        {
            ComportementVol = new NePasVoler();
            ComportementCancan = new Cancan();
        }

        public override void Afficher()
        {
            Console.WriteLine("Je suis un prototype de canar");
        }
    }
}
