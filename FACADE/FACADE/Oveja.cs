using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACADE
{
     class Oveja: Animales
    {
        public override void SonidoAnimal()
        {
            Console.WriteLine("Soy un oveja Beee Beee");
        }
    }
}
