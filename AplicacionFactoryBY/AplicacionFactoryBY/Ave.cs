using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionFactoryBY
{
    class Ave : IAmbienteAnimal
    {
        public void TipoAnimal()
        {
            Console.WriteLine("¡Hola, soy un ave, y suelo vivir en el aire!");
        }
    }
}
