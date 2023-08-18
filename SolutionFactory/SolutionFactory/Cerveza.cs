using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionFactory
{
   public class Cerveza: BebidaEmbriagante
    {
        public override int CuantoMeEmbrigaPorHora()
        {
            return 5;
        }
    }
}
