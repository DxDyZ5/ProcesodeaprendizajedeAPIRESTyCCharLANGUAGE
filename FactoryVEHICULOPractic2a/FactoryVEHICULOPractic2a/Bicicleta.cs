using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace FactoryVEHICULOPractic2a
    {
        class Bicicleta : IVehiculo
        {
            public string Marca { get; set; }
            public string Modelo { get; set; }
            public string Tipo_Vicicleta { get; set; }
            public int Año { get; set; }
            public float Precio { get; set; }

            public Bicicleta()
            {

            }

            public Bicicleta(string marca, string modelo, string tipo_vicicleta, int año, float precio)
            {
                this.Marca = marca;
                this.Modelo = modelo;
                this.Tipo_Vicicleta = tipo_vicicleta;
                this.Año = año;
                this.Precio = precio;
            }

            public void Datos()
            {
                Console.WriteLine(@$"
BICICLETA DISPONIBLE: 
              __
   ,--.      <__)
   `- |________7
      |`.      |\
   .--|. \     |.\--.
  /   j \ `.7__j__\  \
 |   o   | (o)____O)  |
  \     /   J  \     /
   `---'        `---'     
------------------------------------ 
Marca: {Marca}                  
Modelo: {Modelo}
Tipo de bicicleta: {Tipo_Vicicleta}
Año: {Año}                      
Precio: ${Precio}             
    ------------------------------------ 
    ");
            }
        }
}
