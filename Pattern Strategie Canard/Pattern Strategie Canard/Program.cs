using ConsoleApp2.ComportementsVol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Canard colvert = new Colvert();
            colvert.EffectuerCancan();
            colvert.EffectuerVol();

            Canard proto = new PrototypeCanard();
            proto.EffectuerVol();
            proto.SetComportementVol(new PropulsionAReaction());
            proto.EffectuerVol();

        }

    }
   
}
