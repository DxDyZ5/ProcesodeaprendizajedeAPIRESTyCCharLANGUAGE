using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_EX
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1.Nombre = "Juan";
            persona1.Edad = 25;
            persona1.Cedula = "123456789";

            Console.WriteLine(persona1.ToString());
            Console.WriteLine("¿Es mayor de edad? " + persona1.esMayorDeEdad());
           

            Persona persona2 = new Persona("María", 17);
            Console.WriteLine(persona2.ToString());
            Console.WriteLine("¿Es mayor de edad? " + persona2.esMayorDeEdad());
            Console.Read();



            Persona titular = new Persona("Manuel", 19);
            Cuenta cuenta = new Cuenta(titular, 2000);

            Console.WriteLine(cuenta.ToString());

            cuenta.depositar(500);
            Console.WriteLine("Balance después del depósito: " + cuenta.ToString());
            Console.Read();

            cuenta.retirar(200);
            Console.WriteLine("Balance después del retiro: " + cuenta.ToString());
            Console.Read();

            



        }
    }
}
