using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACADE
{
    class FACHADAzooANIMAL
    {
        private Perro perro;
        private Caballo caballo;
        private Elefante elefante;

        public FACHADAzooANIMAL() 
        { 
            perro = new Perro();
            caballo = new Caballo();
            elefante = new Elefante();  
        }

        public void imprimirSonidos()
        {
            perro.SonidoAnimal();
            caballo.SonidoAnimal();
            elefante.SonidoAnimal();
        }

    }
}
