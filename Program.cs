
using Programa_Tienda;

Menu menu = new Menu();
bool menuCondition = true;
do
{
    menu.MenuPrincipal();
    int opcion = int.Parse(Console.ReadLine());
    switch(opcion)
    {
        case 1:
            menu.MenuProductos();
            break;
        case 2:
            menu.MenuCliente();
            break;
        case 3:
            break;
        case 4:
            menuCondition = false;
            break;
    }
}
while (menuCondition);