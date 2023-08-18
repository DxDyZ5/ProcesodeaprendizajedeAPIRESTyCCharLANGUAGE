using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InscripcionEstudiante
{
   public class Estudiantes
    {
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Carerra { get; set; }


        public Estudiantes()
        {

        }

        public Estudiantes(string _Matricula, string _Nombre, string _Apellido, string _Carerra)
        {
            this.Matricula = _Matricula;
            this.Nombre = _Nombre;
            this.Apellido = _Apellido;
            this.Carerra = _Carerra;
        }


        

    }


}
