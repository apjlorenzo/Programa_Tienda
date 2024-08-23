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
            Console.WriteLine(":::::::MENU:::::::");
            Console.WriteLine("1.Gestionar productos.");
            Console.WriteLine("2.Gestionar clientes.");
            Console.WriteLine("3.Realizar ventas.");
            Console.WriteLine("5.Salir.");
            Console.Write("Escriba una opción: ");
        }
        public void MenuProductos()
        {
            Console.WriteLine("1.Agregar un producto.");
            Console.WriteLine("2.Modificar informacíón de un producto.");
            Console.WriteLine("3.Eliminar producto.");
            Console.WriteLine("4.Mostrar productos.");
            Console.Write("Escriba una opción: ");
        }
        public void MenuCliente()
        {
            Console.WriteLine("1.Agregar un cliente.");
            Console.WriteLine("2.Modificar informacíón de un cliente.");
            Console.WriteLine("3.Eliminar cliente.");
            Console.WriteLine("4.Mostrar clientes.");
            Console.Write("Escriba una opción: ");
        }
    }
}
