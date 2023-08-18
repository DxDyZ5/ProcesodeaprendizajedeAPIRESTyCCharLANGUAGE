using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOAutomovil
{
  public  class Electrico: Automovil
    {
        public string Tiempo_de_Carga { get; set; }


        public Electrico(string Tiempo_de_Carga)
        {
            this.Tiempo_de_Carga = Tiempo_de_Carga;
        }

        public override void Encender()
        {
            Console.WriteLine("El electrico se está encendiendo!");
        }

        public override void Mover()
        {
            Console.WriteLine("El electrico se está moviendo!");
        }

        public override void Apagar()
        {
            Console.WriteLine("El electrico se está apagando!");
        }



        public override string ToString()
        {
            return "Marca: " + Marca + " | Modelo: " + Modelo + " | Año: " + Año + " | Tiempo de carga: " + Tiempo_de_Carga;
        }

    }

   
}
