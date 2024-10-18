using TiendaVideojuegos.Enums;

namespace TiendaVideojuegos.Models
{
    public static class Menu
    {
        private static List<Action> acciones = new List<Action>
        {
            PedirAgregarVideojuego,
            MostrarCatalogo,
            PedirActualizarVideojuego,
            PedirEliminarVideojuego,
        };

        public static void MostrarMenu()
        {
            Catalogo.CargarVideojugos();

            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\n1. Agregar videojuego");
                Console.WriteLine("2. Mostrar videojuegos");
                Console.WriteLine("3. Actualizar videojuego");
                Console.WriteLine("4. Eliminar videojuego");
                Console.WriteLine("5. Salir\n");

                int opcion;
                Console.Write("Opcion: ");
                if(int.TryParse(Console.ReadLine(), out opcion) && opcion >= 1 && opcion <= acciones.Count + 1)
                {
                    if(opcion == acciones.Count + 1)
                    {
                        Console.WriteLine("Saliendo");
                        salir = true;
                    }
                    else
                    {
                        acciones[opcion - 1].Invoke();
                    }
                }
                else
                {
                    Console.WriteLine("Opción no válida.");
                }
            }
        }

        private static void CrearVideojuego(string nombre)
        {

            Console.Write("Ingrese el precio del videojuego: ");
            double precio = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el stock del videojuego: ");
            int cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la plataforma del videojuego: ");
            foreach (var p in Enum.GetValues(typeof(Plataforma)))
            {
                Console.WriteLine($"{(int)p}: {p}");
            }
            int seleccion = int.Parse(Console.ReadLine());
            Plataforma plataforma = (Plataforma)seleccion;

            VideoJuego v = new VideoJuego(nombre, precio, cantidad, plataforma);

            Catalogo.AgregarVideoJuego(v);
        }
        public static void PedirAgregarVideojuego()
        {
            Console.Write("\nIngrese el nombre del videojuego: ");
            string nombre = Console.ReadLine();

            CrearVideojuego(nombre);
        }

        public static void MostrarCatalogo() => Catalogo.MostrarVideojuegos();

        public static void PedirActualizarVideojuego()
        {
            Console.Write("\nIngrese el nombre del videojuego a modificar: ");
            string nombre = Console.ReadLine();

            CrearVideojuego(nombre);

            Catalogo.EliminarVideojuego(nombre);
        }

        public static void PedirEliminarVideojuego()
        {
            Console.Write("\nIngrese el nombre del videojuego a eliminar: ");
            string nombre = Console.ReadLine();

            Catalogo.EliminarVideojuego(nombre);
        }
    }
}
