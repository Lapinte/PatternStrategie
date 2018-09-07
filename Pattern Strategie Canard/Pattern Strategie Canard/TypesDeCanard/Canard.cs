using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Canard
    {
        protected IComportementVol ComportementVol { get; set; }
        protected IComportementCancan ComportementCancan { get; set; }

        public Canard()
        {
        }

        public abstract void Afficher();

        public void EffectuerVol()
        {
            ComportementVol.Voler();
        }

        public void EffectuerCancan()
        {
            ComportementCancan.Cancaner();
        }

        public void Nager()
        {
            Console.WriteLine("Tous les canards flottent, même les leurres!");
        }

        public void SetComportementVol (IComportementVol cv)
        {
            ComportementVol = cv;
        }

        public void SetComportementCancan(IComportementCancan cc)
        {
            ComportementCancan = cc;
        }
    }
}
