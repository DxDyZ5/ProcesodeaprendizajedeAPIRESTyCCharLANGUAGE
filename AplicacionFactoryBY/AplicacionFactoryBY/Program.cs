using AplicacionFactoryBY;
using System;
namespace FactoryPROJECT
{
	class Program
	{
		static void Main(string[] args)
		{
            IAmbienteAnimal cuadrupedo = CreadorAnimal.GetAnimal("Tierra");
            cuadrupedo.TipoAnimal();

            IAmbienteAnimal ave = CreadorAnimal.GetAnimal("Aéreo");
            ave.TipoAnimal();



            IAmbienteAnimal pez = CreadorAnimal.GetAnimal("Acuatico");
            pez.TipoAnimal();


        }

	}		

}
