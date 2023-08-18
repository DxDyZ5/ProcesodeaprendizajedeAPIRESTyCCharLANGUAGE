using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACADE
{
     class Vaca: Animales
    {
        public override void SonidoAnimal()
        {
            Console.WriteLine("Soy una vaca Muuu muuu Mugido");
        }
    }
}
