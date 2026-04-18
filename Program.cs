
using ProyectoConsola;

Console.CursorVisible = false;

int opcionmenuprincipal, opcionmenusegundario;

do
{
    opcionmenuprincipal = Interfaz.MenuPrincipal();

    switch (opcionmenuprincipal)
    {
        case 0:
            do
            {
                opcionmenusegundario = Interfaz.MenuSegundario();

                switch (opcionmenusegundario)
                {
                    case 0:
                        Interfaz.MenuDocente();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("-");
                        break;
                }

            } while (opcionmenusegundario != 3);
            break;
        default:
            Console.WriteLine("-");
            break;
    }
} while (opcionmenuprincipal != 3);



