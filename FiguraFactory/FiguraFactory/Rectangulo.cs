using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraFactory
{
     class Rectangulo: IFiguraGeometrica
    {
        private static Rectangulo Orectangulo;
        private string Figura;


        private Rectangulo(string figura)
        {
            Figura = figura;   
        }
        
        public static Rectangulo GetRectangulo(string figura)
        {
            if (Orectangulo == null)
            {
               Orectangulo= new Rectangulo(figura);
                return Orectangulo;
            }
            else
            {
                Console.WriteLine("¡Ya se ha creado una instancia de Rectángulo anteriormente!");
                Environment.Exit(0);
                return Orectangulo;
                
                  
            }
        }

        
        public void TipoDeFigura()
        {
            Console.WriteLine("\n----------RECTANGULO-------------\n");
        }
    }
}
