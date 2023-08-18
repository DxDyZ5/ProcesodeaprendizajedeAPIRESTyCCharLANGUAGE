using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace StrategyMascotas
{
     class FabricadorAnimal
    {
        public static Ipaseo getmascota(string mascota)
        {
            if (mascota.ToLower() == "c")
            {
                return new Chihuahua();
            }
            else if (mascota.ToLower() == "l")
            {
                return new Labrador();
            }
            else if (mascota.ToLower() == "h")
            {
                return new Husky_siberiano();
            }
            else
            {
                return null;
            }
        }
        

        
    }
}
