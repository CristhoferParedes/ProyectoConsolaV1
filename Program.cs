using ProyectoConsola;

Console.CursorVisible = false;

int indexprin;
int indexseg;

Interfaz.MenuPrincipalFijo();

do
{
    indexprin = Interfaz.MenuPrincipal();

    switch (indexprin)
    {
        case 0:
            {
                do
                {
                    indexseg = Interfaz.MenuSecundario(indexprin);

                    if (indexseg != 3)
                    {
                        Interfaz.OperacionRegistrar(indexseg);
                    }

                } while (indexseg != 3);

                break;
            }

        case 2:
            {
                do
                {
                    indexseg = Interfaz.MenuSecundario(indexprin);

                    if (indexseg != 3)
                    {
                        Interfaz.OperacionReporte(indexseg);
                    }

                } while (indexseg != 3);

                break;
            }
    }

} while (indexprin != 3);