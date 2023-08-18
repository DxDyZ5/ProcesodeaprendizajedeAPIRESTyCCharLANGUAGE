using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA1SINGLETON
{
    class Program
    {
        static List<Director> Ldirector = new List<Director>();
        static List<Profesor> Lprofesor = new List<Profesor>();
        static List<PersonalAdministrativo> LpersonAdminist = new List<PersonalAdministrativo>();
        static List<Estudiante> Lestudiante = new List<Estudiante>();
        static void Main(string[] args)
        {
            bool salir = false;
            Console.WriteLine(@"
   ____           _               _____    _                 _   _             
  / ___|___ _ __ | |_ _ __ ___   | ____|__| |_   _  ___ __ _| |_(_)_   _____ _ 
 | |   / _ \ '_ \| __| '__/ _ \  |  _| / _` | | | |/ __/ _` | __| \ \ / / _ (_)
 | |__|  __/ | | | |_| | | (_) | | |__| (_| | |_| | (_| (_| | |_| |\ V / (_) | 
  \____\___|_| |_|\__|_|  \___/  |_____\__,_|\__,_|\___\__,_|\__|_| \_/ \___(_)
 | |    __ _    ___  ___ _ __   ___ _ __ __ _ _ __  ______ _                   
 | |   / _` |  / _ \/ __| '_ \ / _ \ '__/ _` | '_ \|_  / _` |                  
 | |__| (_| | |  __/\__ \ |_) |  __/ | | (_| | | | |/ / (_| |                  
 |_____\__,_|  \___||___/ .__/ \___|_|  \__,_|_| |_/___\__,_|                  
                        |_|                                                                                                    
");

            while (!salir)
            {
                Console.WriteLine("Eliga una de las opciones en pantalla (Elige un número): ");
                Console.WriteLine("1) Crear Director/a");
                Console.WriteLine("2) Crear profesores");
                Console.WriteLine("3) Crear personal administrativo");
                Console.WriteLine("4) Crear estudiantes");
                Console.WriteLine("5) Imprimir tabla de centro educativo");
                Console.WriteLine("6) Acerca de");
                Console.WriteLine("7) Salir");

                try
                {
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            CrearDirector();
                            Console.Write("Presione Enter para continuar...");
                            Console.ReadLine();
                            break;

                        case 2:
                            CrearProfesor();
                            Console.Write("Presione Enter para continuar...");
                            Console.ReadLine();
                            break;

                        case 3:
                            CrearpersonAdminist();
                            Console.Write("Presione Enter para continuar...");
                            Console.ReadLine();
                            break;

                        case 4:
                            CrearEstudiante();
                            Console.Write("Presione Enter para continuar...");
                            Console.ReadLine();

                            break;

                        case 5:
                            ImprimirTabla();
                            Console.Write("Presione Enter para continuar...");
                            Console.ReadLine();

                            break;

                        case 6:
                            Console.WriteLine(@"© 2023 Studio. All rights reserved
                                                                                    by Manuel Torres (MATT)
");
                            Console.Write("Presione Enter para continuar...");
                            Console.ReadLine();
                            break;

                        case 7:
                            Console.WriteLine("Saliendo del programa...");
                            Console.Read();
                            salir = true;
                            break;

                        default:
                            Console.WriteLine("Elige una opción entre 1 y 7");
                            break;
                    }
                    Console.Clear();
                }
                catch (Exception)
                {
                    Console.WriteLine("\nLea las indicaciones antes de presionar cualquier tecla, por favor.\n");
                }
            }
            

        }
        public static void CrearDirector()
        {
            Console.WriteLine(@"
 |____________________________________________________|
  | __     __   ____   ___ ||  ____    ____     _  __  |
  ||  |__ |--|_| || |_|   |||_|**|*|__|+|+||___| ||  | |
  ||==|^^||--| |=||=| |=*=||| |~~|~|  |=|=|| | |~||==| |
  ||  |##||  | | || | |JRO|||-|  | |==|+|+||-|-|~||__| |
  ||__|__||__|_|_||_|_|___|||_|__|_|__|_|_||_|_|_||__|_|
  ||_______________________||__________________________|
  | _____________________  ||      __   __  _  __    _ |
  ||=|=|=|=|=|=|=|=|=|=|=| __..\/ |  |_|  ||#||==|  / /|
  || | | | | | | | | | | |/\ \  \\|++|=|  || ||==| / / |
  ||_|_|_|_|_|_|_|_|_|_|_/_/\_.___\__|_|__||_||__|/_/__|
  |____________________ /\~()/()~//\ __________________|
  | __   __    _  _     \_  (_ .  _/ _    ___     _____| --- Haz elegido la opcion 1, llena los datos, por favor.
  ||~~|_|..|__| || |_ _   \ //\\ /  |=|__|~|~|___| | | |
  ||--|+|^^|==|1||2| | |__/\ __ /\__| |==|x|x|+|+|=|=|=|
  ||__|_|__|__|_||_|_| /  \ \  / /  \_|__|_|_|_|_|_|_|_|
  |_________________ _/    \/\/\/    \_ _______________|
  | _____   _   __  |/      \../      \|  __   __   ___|
  ||_____|_| |_|##|_||   |   \/ __|   ||_|==|_|++|_|-|||
  ||______||=|#|--| |\   \   o    /   /| |  |~|  | | |||
  ||______||_|_|__|_|_\   \  o   /   /_|_|__|_|__|_|_|||
  |_________ __________\___\____/___/___________ ______|
  |__    _  /    ________     ______           /| _ _ _|
  |\ \  |=|/   //    /| //   /  /  / |        / ||%|%|%|
  | \/\ |*/  .//____//.//   /__/__/ (_)      /  ||=|=|=|
__|  \/\|/   /(____|/ //                    /  /||~|~|~|__
  |___\_/   /________//   ________         /  / ||_|_|_|
  |___ /   (|________/   |\_______\       /  /| |______|
      /                  \|________)     /  / | |

");
            Console.Write("Cual es el nombre de el director/a: ");
            string Dnombre = Console.ReadLine();

            Director director = Director.GetDirector(Dnombre);
            Ldirector.Add(director);
            Console.WriteLine("\nDatos guardados exitosamente\n");
        }

        public static void CrearProfesor()
        {
            Console.WriteLine(@"
 |____________________________________________________|
  | __     __   ____   ___ ||  ____    ____     _  __  |
  ||  |__ |--|_| || |_|   |||_|**|*|__|+|+||___| ||  | |
  ||==|^^||--| |=||=| |=*=||| |~~|~|  |=|=|| | |~||==| |
  ||  |##||  | | || | |JRO|||-|  | |==|+|+||-|-|~||__| |
  ||__|__||__|_|_||_|_|___|||_|__|_|__|_|_||_|_|_||__|_|
  ||_______________________||__________________________|
  | _____________________  ||      __   __  _  __    _ |
  ||=|=|=|=|=|=|=|=|=|=|=| __..\/ |  |_|  ||#||==|  / /|
  || | | | | | | | | | | |/\ \  \\|++|=|  || ||==| / / |
  ||_|_|_|_|_|_|_|_|_|_|_/_/\_.___\__|_|__||_||__|/_/__|
  |____________________ /\~()/()~//\ __________________|
  | __   __    _  _     \_  (_ .  _/ _    ___     _____| --- Haz elegido la opcion 2, llena los datos, por favor.
  ||~~|_|..|__| || |_ _   \ //\\ /  |=|__|~|~|___| | | |
  ||--|+|^^|==|1||2| | |__/\ __ /\__| |==|x|x|+|+|=|=|=|
  ||__|_|__|__|_||_|_| /  \ \  / /  \_|__|_|_|_|_|_|_|_|
  |_________________ _/    \/\/\/    \_ _______________|
  | _____   _   __  |/      \../      \|  __   __   ___|
  ||_____|_| |_|##|_||   |   \/ __|   ||_|==|_|++|_|-|||
  ||______||=|#|--| |\   \   o    /   /| |  |~|  | | |||
  ||______||_|_|__|_|_\   \  o   /   /_|_|__|_|__|_|_|||
  |_________ __________\___\____/___/___________ ______|
  |__    _  /    ________     ______           /| _ _ _|
  |\ \  |=|/   //    /| //   /  /  / |        / ||%|%|%|
  | \/\ |*/  .//____//.//   /__/__/ (_)      /  ||=|=|=|
__|  \/\|/   /(____|/ //                    /  /||~|~|~|__
  |___\_/   /________//   ________         /  / ||_|_|_|
  |___ /   (|________/   |\_______\       /  /| |______|
      /                  \|________)     /  / | |

");
            Console.Write("Cual es el nombre de el profesor/a: ");
            string Pnombre = Console.ReadLine();

            Console.Write("Cual es la especialidad de el profesor/a: ");
            string Pespecialidad = Console.ReadLine();

            Profesor profesor = new Profesor(Pnombre, Pespecialidad);
            Lprofesor.Add(profesor);
            Console.WriteLine("\nDatos guardados exitosamente\n");

        }

        public static void CrearpersonAdminist()
        {
            Console.WriteLine(@"
 |____________________________________________________|
  | __     __   ____   ___ ||  ____    ____     _  __  |
  ||  |__ |--|_| || |_|   |||_|**|*|__|+|+||___| ||  | |
  ||==|^^||--| |=||=| |=*=||| |~~|~|  |=|=|| | |~||==| |
  ||  |##||  | | || | |JRO|||-|  | |==|+|+||-|-|~||__| |
  ||__|__||__|_|_||_|_|___|||_|__|_|__|_|_||_|_|_||__|_|
  ||_______________________||__________________________|
  | _____________________  ||      __   __  _  __    _ |
  ||=|=|=|=|=|=|=|=|=|=|=| __..\/ |  |_|  ||#||==|  / /|
  || | | | | | | | | | | |/\ \  \\|++|=|  || ||==| / / |
  ||_|_|_|_|_|_|_|_|_|_|_/_/\_.___\__|_|__||_||__|/_/__|
  |____________________ /\~()/()~//\ __________________|
  | __   __    _  _     \_  (_ .  _/ _    ___     _____| --- Haz elegido la opcion 3, llena los datos, por favor.
  ||~~|_|..|__| || |_ _   \ //\\ /  |=|__|~|~|___| | | |
  ||--|+|^^|==|1||2| | |__/\ __ /\__| |==|x|x|+|+|=|=|=|
  ||__|_|__|__|_||_|_| /  \ \  / /  \_|__|_|_|_|_|_|_|_|
  |_________________ _/    \/\/\/    \_ _______________|
  | _____   _   __  |/      \../      \|  __   __   ___|
  ||_____|_| |_|##|_||   |   \/ __|   ||_|==|_|++|_|-|||
  ||______||=|#|--| |\   \   o    /   /| |  |~|  | | |||
  ||______||_|_|__|_|_\   \  o   /   /_|_|__|_|__|_|_|||
  |_________ __________\___\____/___/___________ ______|
  |__    _  /    ________     ______           /| _ _ _|
  |\ \  |=|/   //    /| //   /  /  / |        / ||%|%|%|
  | \/\ |*/  .//____//.//   /__/__/ (_)      /  ||=|=|=|
__|  \/\|/   /(____|/ //                    /  /||~|~|~|__
  |___\_/   /________//   ________         /  / ||_|_|_|
  |___ /   (|________/   |\_______\       /  /| |______|
      /                  \|________)     /  / | |

");
            Console.Write("Cual es el nombre del personal administrativo: ");
            string PAnombre = Console.ReadLine();

            Console.Write("Cual es el area de responsabilidad del personal administrativo (Recursos Humanos, Finanzas, Admisiones, Servicios estudiantiles, etc): ");
            string PAresponsabilidad = Console.ReadLine();

            PersonalAdministrativo PersonAdmintrin = new PersonalAdministrativo(PAnombre, PAresponsabilidad);
            LpersonAdminist.Add(PersonAdmintrin);
            Console.WriteLine("\nDatos guardados exitosamente\n");

        }
        public static void CrearEstudiante()
        {
            Console.WriteLine(@"
 |____________________________________________________|
  | __     __   ____   ___ ||  ____    ____     _  __  |
  ||  |__ |--|_| || |_|   |||_|**|*|__|+|+||___| ||  | |
  ||==|^^||--| |=||=| |=*=||| |~~|~|  |=|=|| | |~||==| |
  ||  |##||  | | || | |JRO|||-|  | |==|+|+||-|-|~||__| |
  ||__|__||__|_|_||_|_|___|||_|__|_|__|_|_||_|_|_||__|_|
  ||_______________________||__________________________|
  | _____________________  ||      __   __  _  __    _ |
  ||=|=|=|=|=|=|=|=|=|=|=| __..\/ |  |_|  ||#||==|  / /|
  || | | | | | | | | | | |/\ \  \\|++|=|  || ||==| / / |
  ||_|_|_|_|_|_|_|_|_|_|_/_/\_.___\__|_|__||_||__|/_/__|
  |____________________ /\~()/()~//\ __________________|
  | __   __    _  _     \_  (_ .  _/ _    ___     _____| --- Haz elegido la opcion 4, llena los datos, por favor.
  ||~~|_|..|__| || |_ _   \ //\\ /  |=|__|~|~|___| | | |
  ||--|+|^^|==|1||2| | |__/\ __ /\__| |==|x|x|+|+|=|=|=|
  ||__|_|__|__|_||_|_| /  \ \  / /  \_|__|_|_|_|_|_|_|_|
  |_________________ _/    \/\/\/    \_ _______________|
  | _____   _   __  |/      \../      \|  __   __   ___|
  ||_____|_| |_|##|_||   |   \/ __|   ||_|==|_|++|_|-|||
  ||______||=|#|--| |\   \   o    /   /| |  |~|  | | |||
  ||______||_|_|__|_|_\   \  o   /   /_|_|__|_|__|_|_|||
  |_________ __________\___\____/___/___________ ______|
  |__    _  /    ________     ______           /| _ _ _|
  |\ \  |=|/   //    /| //   /  /  / |        / ||%|%|%|
  | \/\ |*/  .//____//.//   /__/__/ (_)      /  ||=|=|=|
__|  \/\|/   /(____|/ //                    /  /||~|~|~|__
  |___\_/   /________//   ________         /  / ||_|_|_|
  |___ /   (|________/   |\_______\       /  /| |______|
      /                  \|________)     /  / | |

");
            Console.Write("Cual es el nombre de el estudiante/a: ");
            string Enombre = Console.ReadLine();

            Console.Write("Cual es el tecnico que esta cursando: ");
            string Etecnico = Console.ReadLine();

            Estudiante estudiante = new Estudiante(Enombre, Etecnico);
            Lestudiante.Add(estudiante);
            Console.WriteLine("\nDatos guardados exitosamente\n");
        }

        public static void ImprimirTabla()
        {
            bool salirUno = false;
            Console.WriteLine(@"
 |____________________________________________________|
  | __     __   ____   ___ ||  ____    ____     _  __  |
  ||  |__ |--|_| || |_|   |||_|**|*|__|+|+||___| ||  | |
  ||==|^^||--| |=||=| |=*=||| |~~|~|  |=|=|| | |~||==| |
  ||  |##||  | | || | |JRO|||-|  | |==|+|+||-|-|~||__| |
  ||__|__||__|_|_||_|_|___|||_|__|_|__|_|_||_|_|_||__|_|
  ||_______________________||__________________________|
  | _____________________  ||      __   __  _  __    _ |
  ||=|=|=|=|=|=|=|=|=|=|=| __..\/ |  |_|  ||#||==|  / /|
  || | | | | | | | | | | |/\ \  \\|++|=|  || ||==| / / |
  ||_|_|_|_|_|_|_|_|_|_|_/_/\_.___\__|_|__||_||__|/_/__|
  |____________________ /\~()/()~//\ __________________|
  | __   __    _  _     \_  (_ .  _/ _    ___     _____| --- Haz elegido la opcion 5, Eliga cual tabla quiere ver.
  ||~~|_|..|__| || |_ _   \ //\\ /  |=|__|~|~|___| | | |
  ||--|+|^^|==|1||2| | |__/\ __ /\__| |==|x|x|+|+|=|=|=|
  ||__|_|__|__|_||_|_| /  \ \  / /  \_|__|_|_|_|_|_|_|_|
  |_________________ _/    \/\/\/    \_ _______________|
  | _____   _   __  |/      \../      \|  __   __   ___|
  ||_____|_| |_|##|_||   |   \/ __|   ||_|==|_|++|_|-|||
  ||______||=|#|--| |\   \   o    /   /| |  |~|  | | |||
  ||______||_|_|__|_|_\   \  o   /   /_|_|__|_|__|_|_|||
  |_________ __________\___\____/___/___________ ______|
  |__    _  /    ________     ______           /| _ _ _|
  |\ \  |=|/   //    /| //   /  /  / |        / ||%|%|%|
  | \/\ |*/  .//____//.//   /__/__/ (_)      /  ||=|=|=|
__|  \/\|/   /(____|/ //                    /  /||~|~|~|__
  |___\_/   /________//   ________         /  / ||_|_|_|
  |___ /   (|________/   |\_______\       /  /| |______|
      /                  \|________)     /  / | |

");


            while (!salirUno)
            {
                Console.WriteLine("Eliga una de las opciones en pantalla (Elige un número): ");
                Console.WriteLine("1) Ver director");
                Console.WriteLine("2) Ver profesor");
                Console.WriteLine("3) Ver personal administrativo");
                Console.WriteLine("4) Ver estudiante");
                Console.WriteLine("5) Salir");

                try
                {
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Nombre");
                            foreach (Director ODdirector in Ldirector)
                            {
                                Console.WriteLine("{0,-10}", ODdirector.ToString());
                                
                            }
                            Console.Write("Presione Enter para continuar...");
                            Console.ReadLine();
                            break;

                        case 2:
                            Console.WriteLine("Nombre  Especialidad");
                            foreach (Profesor profesor in Lprofesor)
                            {
                                Console.WriteLine("{0,-10} {1,-10}", profesor.Nombre, profesor.Especialidad);
                                
                            }
                            Console.Write("Presione Enter para continuar...");
                            Console.ReadLine();
                            break;

                        case 3:
                            Console.WriteLine("Nombre  Area de especialidad");
                            foreach (PersonalAdministrativo ODPersonal in LpersonAdminist)
                            {
                                Console.WriteLine("{0,-10} {1,-10}", ODPersonal.Nombre, ODPersonal.AreaDeResponsabilidad);
                                
                            }
                            Console.Write("Presione Enter para continuar...");
                            Console.ReadLine();
                            break;

                        case 4:
                            Console.WriteLine("Nombre  Tecnico");
                            foreach (Estudiante ODestudiante in Lestudiante)
                            {
                                Console.WriteLine("{0,-10} {1,-10}", ODestudiante.Nombre, ODestudiante.Tecnico);
                                
                            }
                            Console.Write("Presione Enter para continuar...");
                            Console.ReadLine();

                            break;

                        case 5:
                            Console.WriteLine("Saliendo...");
                            Console.Read();
                            salirUno = true;
                            break;

                        default:
                            Console.WriteLine("Elige una opción entre 1 y 5");
                            break;
                    }
                    Console.Clear();
                }
                catch (Exception)
                {
                    Console.WriteLine("\nLea las indicaciones antes de presionar cualquier tecla, por favor.\n");
                }

            }
        }
    }
}
