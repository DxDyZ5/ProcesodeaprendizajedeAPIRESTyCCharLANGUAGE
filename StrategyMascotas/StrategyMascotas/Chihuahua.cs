using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyMascotas
{
     class Chihuahua : Ipaseo
    {
        public void paseito()
        {
            Console.WriteLine("El paseo es de 20 minutos con un costo de RD$100");
        }
    }
}
