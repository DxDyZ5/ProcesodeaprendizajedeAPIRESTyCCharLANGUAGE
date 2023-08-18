using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyMascotas
{
     class Contexto
    {
        Ipaseo paseo;

        public Contexto(Ipaseo paseo)
        {
            this.paseo = paseo;
        }

        public void Obtenerprecio()
        {
            paseo.paseito();
        }
    }
}
