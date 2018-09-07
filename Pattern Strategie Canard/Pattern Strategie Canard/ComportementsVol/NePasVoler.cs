using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class NePasVoler : IComportementVol
    {
        public void Voler()
        {
            Console.WriteLine("Je ne sais pas voler");
        }
    }
}
