using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOAutomovil
{
    public class Automovil 
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }

        public Automovil()
        {

        }

        public Automovil(string Marca, string Modelo, int Año)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Año = Año;

        }

        public virtual void Encender()
        {
            Console.WriteLine("El vehiculo se está encendiendo!");
        }

        public virtual void Mover()
        {
            Console.WriteLine("El vehiculo se está moviendo!");
        }

        public virtual void Apagar()
        {
            Console.WriteLine("El vehiculo se está apagando!");
        }

        public override string ToString()
        {
            return "Marca: " + Marca + " | Modelo: " + Modelo + " | Año: " + Año;
        }


    }
}
