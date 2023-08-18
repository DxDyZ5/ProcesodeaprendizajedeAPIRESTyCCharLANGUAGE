using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryVEHICULOPractic2a
{
    interface IVehiculo
    {
        string Marca { get; }
        string Modelo { get; }
        int Año { get; }
        float Precio { get; }
        void Datos();
    }
}
