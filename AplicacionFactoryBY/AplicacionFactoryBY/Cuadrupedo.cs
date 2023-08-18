using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionFactoryBY
{
    class Cuadrupedo : IAmbienteAnimal
    {
        public void TipoAnimal()
        {
            Console.WriteLine("¡Hola, soy un cuadrúpedo, y suelo vivir en tierra!");
        }
    }
}
