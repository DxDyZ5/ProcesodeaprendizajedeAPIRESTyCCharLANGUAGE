using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryVEHICULOPractic2a
{
    class Carro : IVehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public float Precio { get; set; }

        public Carro()
        {

        }

        public Carro(string marca, string modelo, int año, float precio)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Año = año;
            this.Precio = precio;
        }

        public void Datos()
        {
            Console.WriteLine(@$"
CARRO DISPONIBLE: 
        _______
       //  ||\ \
 _____//___||_\ \___
 )  _          _    \
 |_/ \________/ \___|
___\_/________\_/______
------------------------------------ 
 Marca: {Marca}                  
 Modelo: {Modelo}                
 Año: {Año}                      
 Precio: ${Precio}             
------------------------------------ 
");
        }
    }
}
