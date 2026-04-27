using ProyectoConsola;

Console.CursorVisible = false;

int prin;
int secu;

Interfaz.MenuPrincipalFijo();

do //entrar al bucle
{
    prin = Interfaz.MenuPrincipal(); //escojer una opcion

    switch (prin)
    {
        case 0: //escojer la opcion REGISTRAR
            {
                do //entrar al bucle
                {
                    secu = Interfaz.MenuSecundario(prin); //escojer una opcion dentro de REGISTRAR

                    if (secu != 3) //entrar si es diferente de 3 (SALIR)
                    {
                        Interfaz.OperacionRegistrar(secu);
                    }

                } while (secu != 3);
                break;
            }
        case 1: //escoger ASISTENCIA
            {
                do
                {
                    secu = Interfaz.MenuSecundario(prin);

                    if (secu != 3)
                    {
                        Interfaz.OperacionAsistencia();
                    }

                } while (secu != 3);
                break;
            }
        case 2:
            {
                do
                {
                    secu = Interfaz.MenuSecundario(prin);

                    if (secu != 3)
                    {
                        Interfaz.OperacionReporte(secu);
                    }

                } while (secu != 3);
                break;
            }
    }
} while (prin != 3);