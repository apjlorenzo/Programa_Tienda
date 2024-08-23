using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Tienda
{
    public class Menu
    {
        public void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("==================================");
            Console.WriteLine(":::::::MENU:::::::");
            Console.WriteLine("1.Gestionar productos.");
            Console.WriteLine("2.Gestionar clientes.");
            Console.WriteLine("3.Realizar ventas.");
            Console.WriteLine("4.Salir.");
            Console.WriteLine("==================================\n");
            Console.Write("Escriba una opción: ");
        }
        public void MenuProductos()
        {
            Console.Clear();
            Console.WriteLine("==================================");
            Console.WriteLine(":::::::MENU PRODUCTOS:::::::");
            Console.WriteLine("1.Agregar un producto.");
            Console.WriteLine("2.Modificar informacíón de un producto.");
            Console.WriteLine("3.Eliminar producto.");
            Console.WriteLine("4.Mostrar productos.");
            Console.WriteLine("==================================\n");
            Console.Write("Escriba una opción: ");
        }
        public void MenuCliente()
        {
            Console.Clear();
            Console.WriteLine("==================================");
            Console.WriteLine(":::::::MENU CLIENTES:::::::");
            Console.WriteLine("1.Agregar un cliente.");
            Console.WriteLine("2.Modificar informacíón de un cliente.");
            Console.WriteLine("3.Eliminar cliente.");
            Console.WriteLine("4.Mostrar clientes.");
            Console.WriteLine("==================================\n");
            Console.Write("Escriba una opción: ");
        }

    }
}
