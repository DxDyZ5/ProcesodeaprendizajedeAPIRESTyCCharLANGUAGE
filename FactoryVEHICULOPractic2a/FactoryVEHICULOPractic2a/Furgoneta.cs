using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryVEHICULOPractic2a
{
    class Furgoneta : IVehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public float Precio { get; set; }

        public Furgoneta()
        {

        }

        public Furgoneta(string marca, string modelo, int año, float precio)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Año = año;
            this.Precio = precio;
        }

        public void Datos()
        {
            Console.WriteLine(@$"
FURGONETA DISPONIBLE: 
         __________________________
        /   | |______| |___     __/
       /  , | |  /\  | | ^ |   |       ,--.
     ,' ,'| | |.'  `.| |/ \|   |      /    \
   ,' ,'__| | |______| |___|   |      \    /
  /         |          |   |   |     _ `--'
  [   ,--.  |          |,--|   |]   (_)
  |__/    \_|__________/    \__|= o
     \    /            \    /
---   `--'              `--'

------------------------------------ 
 Marca: {Marca}                  
 Modelo: {Modelo}                
 Año:  {Año}                      
 Precio: ${Precio}             
------------------------------------ 
");
        }
    }
}
