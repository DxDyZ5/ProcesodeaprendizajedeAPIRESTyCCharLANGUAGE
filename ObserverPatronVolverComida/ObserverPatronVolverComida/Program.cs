using ObserverPatronVolverComida;
using System;

namespace ComidaMenu
{
	class Program
	{
		static void Main(string[] args)
		{
			Comida olorsote = new Comida();

			Gato gato = new Gato();
			Perro perro = new Perro();
			Conejo conejo = new Conejo();

			olorsote.agregarSUB(gato);
			olorsote.agregarSUB(perro);
			olorsote.agregarSUB(conejo);


			olorsote.ComidaOlor("pescado");

            Console.ReadLine();


            olorsote.quitarSUB(gato);
			

            olorsote.ComidaOlor("pescado"); //Clase observadora quitada por lo tanto no va aparecer
            olorsote.ComidaOlor("pollo");
			olorsote.ComidaOlor("ensalada");

			Console.ReadKey();
        }
	}
}	
