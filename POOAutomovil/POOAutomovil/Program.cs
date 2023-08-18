using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOAutomovil
{
    class Program
    {
        static void Main(string[] args)
        {
            //Para vehiculo
            Automovil vehiculo = new Automovil();
            vehiculo.Marca = "Toyota";
            vehiculo.Modelo = "Corrolla";
            vehiculo.Año = 2012;
            vehiculo.Encender();
            vehiculo.Mover();
            vehiculo.Apagar();
            Console.WriteLine(vehiculo.ToString());
            Console.WriteLine("---------------------------------------------------------------------------------\n");
           

            //Para camioneta
            Camioneta camioneta = new Camioneta("1500L");
            camioneta.Marca = "Ford";
            camioneta.Modelo = "F-150";
            camioneta.Año = 2008;
            camioneta.Encender();
            camioneta.Mover();
            camioneta.Apagar();
            Console.WriteLine(camioneta.ToString());
            Console.WriteLine("---------------------------------------------------------------------------------\n");
            

            //Para electrico
            Electrico electrico = new Electrico("2h 30m");
            electrico.Marca = "Tesla";
            electrico.Modelo = "Model 3";
            electrico.Año = 2017;
            electrico.Encender();
            electrico.Mover();
            electrico.Apagar();
            Console.WriteLine(electrico.ToString());
            Console.Read();



        }
    }
}
