using FactoryVEHICULOPractic2a;
using System;
namespace VehiculoFactory
{
    class Program
    {
        static List<Factura> historialCompras = new List<Factura>();
        static void Main(string[] args)
        {

            bool salir = false;
            while (!salir)
            {
                Console.WriteLine(@"-sistema de gestión de vehículos:Omar-
---------Vehiculos----------
|     1) Motocicleta       | 
|     2) Carro             |
|     3) Electrico         |
|     4) Furgoneta         |
|     5) Bicicleta         |
|     6) Mostrar historial |
|     7) Salir             |
----------MATT--------------");

                try
                {
                    Console.Write("Eliga una de las opciones que desee (Eliga un numero): ");
                    string opcion = Console.ReadLine();
                    switch (opcion)
                    {
                        case "1":
                            IVehiculo Motocicleta = CreadorVehiculo.GetVehiculo(opcion);
                            Motocicleta.Datos();
                            LogicComprar(Motocicleta);
                            break;
                        case "2":
                            IVehiculo Carro = CreadorVehiculo.GetVehiculo(opcion);
                            Carro.Datos();
                            LogicComprar(Carro);
                            break;
                        case "3":
                            IVehiculo Electrico = CreadorVehiculo.GetVehiculo(opcion);
                            Electrico.Datos();
                            LogicComprar(Electrico);
                            break;
                        case "4":
                            IVehiculo Furgoneta = CreadorVehiculo.GetVehiculo(opcion);
                            Furgoneta.Datos();
                            LogicComprar(Furgoneta);
                            break;
                        case "5":
                            IVehiculo Bicicleta = CreadorVehiculo.GetVehiculo(opcion);
                            Bicicleta.Datos();
                            LogicComprar(Bicicleta);
                            break;
                        case "6":
                            MostrarHistorial();
                            break;
                        case "7":
                            Console.WriteLine("Saliendo del programa...");
                            Console.Read();
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Elige una opción entre 1 y 7");
                            break;
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("\nLea las indicaciones antes de presionar cualquier tecla, por favor.\n");
                }
            }
        }

        public static void LogicComprar(IVehiculo vehiculo)
        {
            Console.Write("¿Confirma la compra? (s/n): ");
            string confirmacion = Console.ReadLine();

            if (confirmacion == "s")
            {
                Console.Clear();
                Console.WriteLine("¡Compra confirmada!");
                Console.WriteLine("Generando factura...");

                Factura factura = new Factura(vehiculo.Marca, vehiculo.Modelo, vehiculo.Año, vehiculo.Precio);
                historialCompras.Add(factura);

                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Factura generada correctamente:");
                Console.WriteLine(factura.ObtenerDetalleFactura());
            }
            else
            {
                Console.WriteLine("Compra cancelada.");
            }
        }

        public static void MostrarHistorial()
        {
            Console.Clear();
            Console.WriteLine("----- Historial de Compras -----");

            if (historialCompras.Count == 0)
            {
                Console.WriteLine("No se ha realizado ninguna compra.");
            }
            else
            {
                float total = 0;
                foreach (Factura factura in historialCompras)
                {
                    Console.WriteLine(factura.ObtenerDetalleFactura());
                    Console.WriteLine("--------------------------------");
                    total += factura.Precio;
                }

                Console.WriteLine($"Total: ${total}");
                ImprimirHistorial();

            }
            Console.WriteLine();

        }

        public static void ImprimirHistorial() 
        {

            Console.Write("Desea guardar los datos en un archivo de texto s/n: ");
            string imprimir = Console.ReadLine();

            if (imprimir == "s")
            {
                string nombreArchivo = "historial.txt";  // Normalmente el texto se guarda en debug, donde esta el ejecutable de la consola, el texto con los datos deberia estar ahi.

                try
                {
                    using (StreamWriter sw = new StreamWriter(nombreArchivo))
                    {
                        foreach (Factura factura in historialCompras)
                        {
                            sw.WriteLine(factura.ObtenerDetalleFactura());
                            sw.WriteLine("--------------------------------");
                        }
                        float total = historialCompras.Sum(factura => factura.Precio);
                        sw.WriteLine($"Total: ${total}");
                    }

                    Console.WriteLine("Historial guardado correctamente en el archivo: " + nombreArchivo);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al guardar el historial: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("No se guardará el historial en un archivo de texto.");
            }
        }






    }
}


