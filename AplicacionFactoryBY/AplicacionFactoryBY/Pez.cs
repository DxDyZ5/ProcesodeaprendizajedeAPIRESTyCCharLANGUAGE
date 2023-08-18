using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionFactoryBY
{
    class Pez : IAmbienteAnimal
    {
        public void TipoAnimal()
        {
            Console.WriteLine("¡Hola, soy un pez, y suelo vivir en el agua!");
        }
    }
}

