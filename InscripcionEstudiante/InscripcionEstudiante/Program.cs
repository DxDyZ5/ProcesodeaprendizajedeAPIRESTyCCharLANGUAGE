using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InscripcionEstudiante //MATT
{
    class Program
    {
        static List<Estudiantes> estudiantes = new List<Estudiantes>();
        static List<Asignaturas> asignaturas = new List<Asignaturas>();
        static List<Secciones> secciones = new List<Secciones>();

        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("--------INSCRIPSCION--------");
                Console.WriteLine("1. Crear Estudiantes");
                Console.WriteLine("2. Crear Asignaturas ");
                Console.WriteLine("3. Crear Secciones ");
                Console.WriteLine("4. Inscribir materias");
                Console.WriteLine("5. Imprimir horario");
                Console.WriteLine("6. Salir");
                Console.WriteLine("Elige una de las opciones");

                try
                {
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            CrearEstudiante();
                            break;

                        case 2:
                            CrearAsignatura();
                            break;

                        case 3:
                            CrearSeccion();
                            break;

                        case 4:
                            InscribirMaterias();
                            break;

                        case 5:
                            ImprimirHorario();
                            break;

                        case 6:
                            Console.WriteLine("¿Estás seguro?");
                            Console.Read();
                            salir = true;
                            break;

                        default:
                            Console.WriteLine("Elige una opción entre 1 y 6");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Lee las indicaciones antes de presionar cualquier tecla");
                }
            }
        }

        public static void CrearEstudiante()
        {
            Console.WriteLine("Has elegido la opción 1");

            Console.WriteLine("Introduzca la matrícula: ");
            string matricula = Console.ReadLine();

            Console.WriteLine("Introduzca el nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Introduzca el apellido: ");
            string apellido = Console.ReadLine();

            Console.WriteLine("Introduzca su carrera: ");
            string carrera = Console.ReadLine();

            Estudiantes estudiante = new Estudiantes(matricula, nombre, apellido, carrera);
            estudiantes.Add(estudiante);

            Console.WriteLine("\n");
        }

        public static void CrearAsignatura()
        {
            Console.WriteLine("Has elegido la opción 2");

            Console.WriteLine("Introduzca el codigo de la asignatura: ");
            string codigo = Console.ReadLine();

            Console.WriteLine("Introduzca el nombre de la asignatura: ");
            string nombre = Console.ReadLine();

            Asignaturas asignatura = new Asignaturas(codigo, nombre);
            asignaturas.Add(asignatura);

            Console.WriteLine("\n");
        }

        public static void CrearSeccion()
        {
            Console.WriteLine("Has elegido la opción 3");

            Console.WriteLine("Introduzca el codigo de la asignatura: ");
            string codigoAsignatura = Console.ReadLine();

            Asignaturas asignaturaSeleccionada = asignaturas.Find(a => a.Codigo == codigoAsignatura);

            if (asignaturaSeleccionada != null)
            {
                Console.WriteLine("Introduzca el horario: ");
                string horario = Console.ReadLine();

                Console.WriteLine("Introduzca el aula: ");
                string aula = Console.ReadLine();

                Secciones seccion = new Secciones(asignaturaSeleccionada, horario, aula);
                secciones.Add(seccion);
              Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("\nLa asignatura no existe. Por favor, primero crea la asignatura\n");
            }
        }

        public static void InscribirMaterias()
        {
            Console.WriteLine("Has elegido la opción 4");

            Console.WriteLine("Introduzca la matrícula del estudiante: ");
            string matricula = Console.ReadLine();

            Estudiantes estudiante = estudiantes.Find(e => e.Matricula == matricula);

            if (estudiante != null)
            {
                Console.WriteLine("El usuario ha sido inscripto exitosamente, para ver el horario ingrese a la opcion 5, por favor");
            }
            else
            {
                Console.WriteLine("El estudiante no existe. Por favor, primero crea el estudiante\n");
            }
        }

        public static void ImprimirHorario()
        {
            Console.WriteLine("Has elegido la opción 5");

            Console.WriteLine("Matrícula  Estudiante  Materia  Horario  Aula");

            foreach (Estudiantes estudiante in estudiantes)
            {
                foreach (Secciones seccion in secciones)
                {
                    if (seccion.asignaturas != null)
                    {
                        Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10} {4,-10}", estudiante.Matricula, estudiante.Nombre, seccion.asignaturas.Nombre, seccion.Horario, seccion.Aula);
                    }
                }
            }
        }
    }
}

