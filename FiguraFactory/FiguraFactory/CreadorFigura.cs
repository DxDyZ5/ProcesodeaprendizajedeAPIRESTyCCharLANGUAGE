using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraFactory
{
    class CreadorFigura
    {
        public static IFiguraGeometrica GetFiguraGeometrica(string figura)
        {
           if (figura == "1")
            {
                return new Triangulo();
                
            } 
           else if (figura == "2")
            {
                return Rectangulo.GetRectangulo(figura);
            }
           else
            {
                return null;
            }

        } 
    }
}
