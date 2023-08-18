using StrategyMascotas;
using System;


namespace mascotasStrategy
{
	class Program
	{
		static void Main(string[] args)
		{
            Contexto contexto = null;
            Console.Clear();

            Console.WriteLine("Eliga una de estas opciones [C]Chihuahua [L]Labrador  [H]Husky siberiano [S]Salir ");
                string mascota = Console.ReadLine();


            if (mascota.ToLower() == "s")
            {

                Console.WriteLine("Saliendo del programa...");
                return;
            }

            contexto = new Contexto(FabricadorAnimal.getmascota(mascota));
            contexto.Obtenerprecio();
            Console.ReadLine();

    

            Main(args);

        }

	}

}
