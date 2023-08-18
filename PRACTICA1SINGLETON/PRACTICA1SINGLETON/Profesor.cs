using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA1SINGLETON
{
    public class Profesor
    {
        public string Nombre;
        public string Especialidad;


        public Profesor()
        {

        }

        public Profesor(string nombre, string especialidad)
        {
            this.Nombre = nombre;
            this.Especialidad = especialidad;
        }



    }


}
