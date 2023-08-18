using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InscripcionEstudiante
{
    public class Asignaturas
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }

        public Asignaturas()
        {

        }

        public Asignaturas(string _Codigo, string _Nombre)
        {
            this.Codigo = _Codigo;
            this.Nombre = _Nombre;
          
        }

    }

}
