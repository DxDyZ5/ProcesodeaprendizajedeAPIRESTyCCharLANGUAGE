using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOAutomovil
{
   public class Camioneta: Automovil
    {
      
        public string Capacidad_De_Carga { get; set; }


        public Camioneta(string Capacidad_De_Carga)
        {
            this.Capacidad_De_Carga = Capacidad_De_Carga;
        }


        public override void Encender()
        {
            Console.WriteLine("La camioneta se está encendiendo!");
        }

        public override void Mover()
        {
            Console.WriteLine("La camioneta se está moviendo!");
        }

        public override void Apagar()
        {
            Console.WriteLine("La camioneta se está apagando!");
        }

        public override string ToString()
        {
            return "Marca: " + Marca + " | Modelo: " + Modelo + " | Año: " + Año + " | Capacidad de carga: " + Capacidad_De_Carga;
        }

    }




}
