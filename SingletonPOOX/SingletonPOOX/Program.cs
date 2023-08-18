using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPOOX
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("--------BIENVENIDO-------");
                Console.WriteLine("1. Crear ASIGNACION");
                Console.WriteLine("2. Salir");
                Console.WriteLine("Elige una de las opciones");


                try
                {
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            CrearASIGNACIONDE();
                            break;

                        case 2:
                            Console.WriteLine("bye!");
                            Console.Read();
                            salir = true;
                            break;

                        default:
                            Console.WriteLine("Elige una opción entre 1 y 2");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Lee las indicaciones antes de presionar cualquier tecla");
                }

            }
        }

        public static void CrearASIGNACIONDE()
        {
            
            
            Console.WriteLine("Cual es el apellido de la familia: ");
            string apellido = Console.ReadLine();

            Console.WriteLine("Cual es la especie de la mascota");
            string especie = Console.ReadLine();

            Console.WriteLine("Cual es la nombre de la mascota");
            string nombre = Console.ReadLine();

            Mascota oMascota = Mascota.ObtenerMascota(especie, nombre);
            Familias Ofamilia = new Familias(apellido, oMascota);

            Console.WriteLine(Ofamilia);

           


        }




        
       
    }
}
