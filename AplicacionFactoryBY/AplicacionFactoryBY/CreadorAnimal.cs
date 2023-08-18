using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionFactoryBY
{
    class CreadorAnimal
    {
        public static IAmbienteAnimal GetAnimal(string ambiente)
        {
            if (ambiente == "Tierra")
            {
                return new Cuadrupedo();
            }
            else if (ambiente == "Aéreo")
            {
                return new Ave();
            }
            else if (ambiente == "Acuatico")
            {
                return new Pez();
            }
            else
            {
                return null;
            }
        }
    }
}
  
