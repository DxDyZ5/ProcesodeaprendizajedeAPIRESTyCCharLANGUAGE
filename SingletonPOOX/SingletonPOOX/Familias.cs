using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPOOX
{
   public class Familias
    {
        public string apellido;
        public Mascota mascota;


        public Familias(string apellido, Mascota mascota)
        {
            this.apellido = apellido;
            this.mascota = mascota;
        }

        public override string ToString()
        {
            return $"El apellido de la familia es: {apellido} {mascota.ToString()}";
        }

    }


  
  
}
