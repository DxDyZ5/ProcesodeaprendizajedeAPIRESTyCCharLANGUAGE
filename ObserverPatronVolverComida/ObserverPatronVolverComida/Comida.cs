using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatronVolverComida
{
     class Comida
    {
        public static string Olor { get; set; }

        public List<Iobservador> observandoOlor = new List<Iobservador>();

        public void agregarSUB(Iobservador iobservador)
        {
            observandoOlor.Add(iobservador);
        }

        public void quitarSUB(Iobservador iobservador)
        {
            observandoOlor.Remove(iobservador);
        }

        public void notificar()
        {
            foreach(var oB in observandoOlor)
            {
                oB.actualizar();
            }
        }


        public void ComidaOlor(string olorsito)
        {
            Olor = olorsito;
            notificar();
        }
    }
}
