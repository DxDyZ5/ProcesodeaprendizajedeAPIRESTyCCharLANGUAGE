using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InscripcionEstudiante
{
    public class Secciones
    {
        public Asignaturas asignaturas { get; set; }
        public string Horario { get; set; }
        public string Aula { get; set; }



        public Secciones()
        {

        }

        public Secciones(Asignaturas _asignaturas ,string _Horario, string _Aula)
        {
            this.asignaturas = _asignaturas;
            this.Horario = _Horario;
            this.Aula = _Aula;

        }



    }
   
}
