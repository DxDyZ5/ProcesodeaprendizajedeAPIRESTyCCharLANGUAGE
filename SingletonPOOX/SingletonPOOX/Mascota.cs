using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPOOX
{
   public class Mascota
    {
        private static Mascota mascota;
        private string _especie;
        private string _nombre;

        private Mascota(string especie, string nombre)
        {
            _especie = especie;
            _nombre = nombre;
        }

        public static Mascota ObtenerMascota(string especie, string nombre)
        {
            if (mascota == null)
            {
                mascota = new Mascota(especie, nombre);
                return mascota;
            }
            else
            {
                return mascota;
            }
            

            
        }

        public override string ToString()
        {
            return $"  La especie de la mascota es:{_especie}   Y el nombre de la mascota es: {_nombre} ";
        }

    }

   


}
