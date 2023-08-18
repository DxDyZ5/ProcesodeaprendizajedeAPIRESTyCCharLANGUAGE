using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA1SINGLETON
{
    public class PersonalAdministrativo
    {
        public string Nombre;
        public string AreaDeResponsabilidad;


        public PersonalAdministrativo()
        {

        }

        public PersonalAdministrativo(string nombre, string areaderesponsabilidad)
        {
            this.Nombre = nombre;
            this.AreaDeResponsabilidad = areaderesponsabilidad;
          
        }


    }


}
