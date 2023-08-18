using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_EX
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Cedula { get; set; }



        public Persona()
        {
            this.Nombre = "";
            this.Edad = 0;
            this.Cedula = "";
        }

        public Persona(string Nombre, int edad)
        {
            this.Nombre = Nombre;
            this.Edad = edad;
            this.Cedula = "";

        }

        public Persona(string nombre, int edad, string cedula)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Cedula = cedula;
        }



        public override string ToString()
        {
            return "Nombre: " + Nombre + ", Edad: " + Edad + ", Cédula: " + Cedula;
        }

        public Boolean esMayorDeEdad()
        {
            return Edad >= 18;
        }

    }
}
