using System;
using System.IO;

namespace FiguraFactory
{
    class Program
    {
       
        static void Main(string[] args)
        {

            String opcion;
            string continuar;
            do
            {
                Console.WriteLine("----Figuras geometricas----");
                Console.WriteLine("| 1) Crear Triangulo  |");
                Console.WriteLine("| 2) Crear Rectangulo |");
                Console.WriteLine("| 3) Salir            |");
                Console.WriteLine("---------MATT----------");
                ;
                Console.Write("Elige una de las opciones: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        IFiguraGeometrica Triangulo = CreadorFigura.GetFiguraGeometrica(opcion);
                        Triangulo.TipoDeFigura();
                        CrearTriangulo();
                        break;
                    case "2":
                        IFiguraGeometrica Rectangulo = CreadorFigura.GetFiguraGeometrica(opcion);
                        Rectangulo.TipoDeFigura();
                        CrearRectangulo();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine("------------------------------------");
                Console.Write("¿Desea continuar? s/n: ");
                continuar = Console.ReadLine();
                Console.WriteLine(" ");
                

            } while (continuar != "n");
            Console.WriteLine("¡Vuelva pronto!");
            Console.ReadKey();






        }

        public static void CrearTriangulo()
        {
            int x, y, altura;
            Console.Write("Ingresar la altura del triangulo: ");
            altura = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");



            for (x = 1; x <= altura; x++)
            {
                for (y = altura - x; y > 0; y--)
                {

                    Console.Write(" ");

                }
                for (y = 1; y < x; y++)
                {
                    Console.Write("**");

                }
                Console.WriteLine("*");


            }


        }


        public static void CrearRectangulo()
        {
            int base1, altura, x, y;
            Console.Write("Ingresar la base del rectangulo: ");
            base1 = int.Parse(Console.ReadLine());
            Console.Write("Ingresar la base del rectangulo: ");
            altura = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");



            for (x = 1; x <= altura; x++)
            {
                for (y = 1; y <= base1; y++)
                {

                    Console.Write("* ", y);

                }
                Console.WriteLine(" ");

            }

           


        }
    }
}
