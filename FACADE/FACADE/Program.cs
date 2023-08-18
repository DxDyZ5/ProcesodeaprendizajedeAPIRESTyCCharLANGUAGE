using FACADE;
using System;
namespace FACADEzoo
{
	class Program
	{
		static void Main(string[] args)
		{
			FACHADAzooANIMAL zoo = new FACHADAzooANIMAL();

			try
			{
                Console.WriteLine("Eliga una de estas opciones [1]Imprimir tres animales [2] Salir");
                int imprimir = Convert.ToInt32(Console.ReadLine());

                if (imprimir == 1)
                {
                    zoo.imprimirSonidos();
                }
                else if (imprimir == 2)
                {
                    Console.WriteLine("Saliendo del programa...");
                    return;
                }

            }
			catch (Exception)
			{
                Console.WriteLine("Escribe algunas de los numeros que ve en pantalla 1 o 2");

            }
            

            Main(args);
		}

	}
}

