using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            BebidaEmbriagante obebida = Creador.CreadorBebida(Creador.VINO_TINTO);
            Console.WriteLine(obebida.CuantoMeEmbrigaPorHora());
            Console.Read();
        }
    }
}
