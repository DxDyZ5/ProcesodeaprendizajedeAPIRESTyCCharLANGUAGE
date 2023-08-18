using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA1SINGLETON
{
    public class Director
    {
        private static Director odirector;
        private string Nombre;

        private Director(string nombre)
        {
            this.Nombre = nombre;
        }

        public static Director GetDirector(string nombre)
        {
            if (odirector == null)
            {
                odirector = new Director(nombre);
                return odirector;
            }
            else
            {
                return odirector;
            }

        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
