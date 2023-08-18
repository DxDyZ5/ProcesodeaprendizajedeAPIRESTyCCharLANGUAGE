using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatronVolverComida
{
     class Gato: Iobservador
    {
        public void actualizar()
        {
            if (Comida.Olor.ToLower() == "pescado")
            {
                Console.WriteLine("MIAUUUUUUUUU FOOD");
            }
        }
    }
}
