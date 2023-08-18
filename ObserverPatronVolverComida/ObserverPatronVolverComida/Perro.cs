using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatronVolverComida
{
     class Perro : Iobservador
    {
        public void actualizar()
        {
            if (Comida.Olor.ToLower() == "pollo")
            {
                Console.WriteLine("WUAO WUAO FOOD");
            }
        }
    }
}
