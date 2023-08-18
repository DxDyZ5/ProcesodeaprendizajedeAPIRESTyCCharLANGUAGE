using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionFactory
{
   public class VinoTinto: BebidaEmbriagante
    {
        public override int CuantoMeEmbrigaPorHora()
        {
            return 20;    
        }
    }
}
