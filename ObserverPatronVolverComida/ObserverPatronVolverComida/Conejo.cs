using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatronVolverComida
{
     class Conejo : Iobservador
    {
        public void actualizar()
        {
            if (Comida.Olor.ToLower() == "ensalada")
            {
                Console.WriteLine("NI NI NI NI FOOD");
            }   
        }
    }
}
