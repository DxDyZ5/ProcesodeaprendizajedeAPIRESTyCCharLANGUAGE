using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryVEHICULOPractic2a
{
    class Factura
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public float Precio { get; set; }
        public Factura(string marca, string modelo, int año, float precio)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
            Precio = precio;
        }

        public string ObtenerDetalleFactura()
        {
            return @$"
---------------- FACTURA ----------------
Marca: {Marca}
Modelo: {Modelo}
Año: {Año}
Precio: ${Precio}
-----------------------------------------";
        }
    }
}

