using ProyectoConsola;

//Console.CursorVisible = false;

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
                    indexseg = Interfaz.MenuSegundario();

                    if (indexseg != 3)
                    {
                        Interfaz.OperacionRegistar(indexseg);            
                    }

                    break;
                } while (indexseg != 3);
                break;
            }        
    }
} while (indexprin != 3);



