using System;
using System.Collections.Generic;
using System.Linq;

namespace GestorContactos
{
    public class GestorContactos
    {
        private List<Contacto> contactos = new List<Contacto>();

        public void AgregarContacto(Contacto c)
        {
            contactos.Add(c);
            Console.WriteLine("✅ Contacto agregado correctamente.\n");
        }

        public void ListarContactos()
        {
            Console.WriteLine("\n📋 Lista de contactos:");
            foreach (var c in contactos)
            {
                Console.WriteLine($"- {c.Nombre}: {c.Telefono}");
            }
            Console.WriteLine();
        }

        public void BuscarContacto(string nombre)
        {
            var encontrados = contactos.Where(c => c.Nombre.Contains(nombre, StringComparison.OrdinalIgnoreCase)).ToList();
            if (encontrados.Any())
            {
                Console.WriteLine("\n🔎 Contactos encontrados:");
                foreach (var c in encontrados)
                    Console.WriteLine($"- {c.Nombre}: {c.Telefono}");
            }
            else
            {
                Console.WriteLine("\n⚠️ No se encontró ningún contacto con ese nombre.");
            }
        }
    }
}
