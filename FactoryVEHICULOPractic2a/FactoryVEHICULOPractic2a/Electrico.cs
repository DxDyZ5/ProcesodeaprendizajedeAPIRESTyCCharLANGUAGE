using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryVEHICULOPractic2a
{
    class Electrico : IVehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Tiempo_de_Carga { get; set; }
        public int Año { get; set; }
        public float Precio { get; set; }

        public Electrico()
        {

        }

        public Electrico(string marca, string modelo, string tiempo_de_carga, int año, float precio)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Tiempo_de_Carga = tiempo_de_carga;
            this.Año = año;
            this.Precio = precio;
        }
       
        public void Datos()
        {
            Console.WriteLine(@$"
ELECTRICO DISPONIBLE: 
  _______
   /______/""=,
  [     | ""=, ""=,,
  [-----+----""=,* )
  (_---_____---_)/
    (O)     (O)
------------------------------------ 
 Marca: {Marca}                  
 Modelo: {Modelo}
 Tiempo de carga: {Tiempo_de_Carga}
 Año: {Año}                      
 Precio: ${Precio}             
------------------------------------ 
");
        }
    }
}
