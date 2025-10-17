using System;

namespace GestorContactos
{
    class Program
    {
        static void Main(string[] args)
        {
            GestorContactos gestor = new GestorContactos();
            int opcion;

            do
            {
                Console.WriteLine("====== GESTOR DE CONTACTOS ======");
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Listar contactos");
                Console.WriteLine("3. Buscar contacto");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.Write("Ingrese el nombre: ");
                            string nombre = Console.ReadLine();
                            Console.Write("Ingrese el teléfono: ");
                            string telefono = Console.ReadLine();
                            gestor.AgregarContacto(new Contacto(nombre, telefono));
                            break;

                        case 2:
                            gestor.ListarContactos();
                            break;

                        case 3:
                            Console.Write("Ingrese el nombre a buscar: ");
                            string busqueda = Console.ReadLine();
                            gestor.BuscarContacto(busqueda);
                            break;

                        case 4:
                            Console.WriteLine("👋 Saliendo del programa...");
                            break;

                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                }

            } while (opcion != 4);
        }
    }
}
