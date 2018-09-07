using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.ComportementsVol
{
    class PropulsionAReaction : IComportementVol
    {
        public void Voler()
        {
            Console.WriteLine("Je vole avec un réacteur !");
        }
    }
}
