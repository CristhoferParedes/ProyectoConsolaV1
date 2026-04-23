namespace ProyectoConsola
{
    public class Interfaz
    {
        public static void MenuPrincipalFijo()
        {
            Console.SetCursorPosition(0, 0);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" -------------------------------------------------------------- ");
            Console.WriteLine("                 SISTEMA DE GESTION DE ASISTENCIAS              ");
            Console.WriteLine(" -------------------------------------------------------------- ");
            Console.ResetColor();

            Console.SetCursorPosition(0, 25);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" -------------------------------------------------------------- ");
            Console.ResetColor();
        }
        public static int MenuPrincipal()
        {
            string[] opciones = { "REGISTRAR", "ASISTENCIA", "REPORTES", "SALIR"};
            int index = 0;
            ConsoleKey tecla;

            do
            {
                Console.SetCursorPosition(0, 3);

                for (int i = 0; i < opciones.Length; i++)
                {
                    if (i == index)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write($"    {opciones[i]}    ");
                        Console.ResetColor();
                    }
                    else Console.Write($"    {opciones[i]}    ");                  
                }

                tecla = Console.ReadKey(true).Key;

                if (tecla == ConsoleKey.RightArrow)
                {
                    index++;
                    if (index > opciones.Length - 1) index = 0;        
                }
                else if (tecla == ConsoleKey.LeftArrow)
                {
                    index--;
                    if (index < 0) index = opciones.Length - 1;                   
                }
            }
            while (tecla != ConsoleKey.Enter);

            return index;
        }
        public static int MenuSecundario(int dato)
        {
            string[] opciones = {"DOCENTE", "ESTUDIANTE", "CURSOS", "SALIR"};
            int index = 0;
            ConsoleKey tecla;

            int position = 3 + (dato * 17);

            do
            {
                for (int i = 0; i < opciones.Length; i++)
                {
                    if (i == index)
                    {
                        Console.SetCursorPosition(position, (4 + i));
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($" {opciones[i]} ");
                        Console.ResetColor();
                    }
                    else
                    {

                        Console.SetCursorPosition(position, (4 + i));
                        Console.WriteLine($" {opciones[i]} ");                   

                    }
                }
                
                tecla = Console.ReadKey(true).Key;

                if (tecla == ConsoleKey.DownArrow)
                {
                    index++;
                    if (index > opciones.Length - 1) index = 0;
                }
                else if (tecla == ConsoleKey.UpArrow)
                {
                    index--;
                    if (index < 0) index = opciones.Length - 1;
                }

            } while (tecla != ConsoleKey.Enter);

            //limpia cuando termina el bucle while y se regresa al do while anterior.
            Console.SetCursorPosition(0, 4);
            Console.WriteLine("                                                         ");
            Console.WriteLine("                                                         ");
            Console.WriteLine("                                                         ");
            Console.WriteLine("                                                         ");

            return index;
        }

        public static void OperacionRegistrar(int num)
        {
            int dni = 0;
            string nomb = "";
            bool validado = false;
            string nombreN = "";
            string nombreP = "";
            string nom = "";
            string pron = "";
            int precio = 0;

            while (!validado)
            {
                

                //Limpia despues de escribir datos incorrectos.
                Console.SetCursorPosition(20, 7);
                Console.WriteLine("                                                ");


                switch (num)
                {
                    case 0:
                        {
                            nom = "DOCENTE";
                            nombreN = $"     DNI {nom}: ";
                            nombreP = $"  NOMBRE {nom}: ";
                            pron = "al";
                            break;
                        }
                    case 1:
                        {
                            nom = "ESTUDIANTE";
                            nombreN = $"  DNI {nom}: ";
                            nombreP = $"NOMBR {nom}: ";
                            pron = "al";

                            break;
                        }
                    case 2:
                        {
                            nom = "CURSO";
                            nombreN = $"    CODIGO {nom}: ";
                            nombreP = $"    NOMBRE {nom}: ";
                            pron = "el";

                            break;
                        }
                }

                Console.SetCursorPosition(2, 7);
                Console.WriteLine(nombreN);
                
                Console.SetCursorPosition(20, 7);
                dni = int.Parse(Console.ReadLine());
                validado = Logica.ValidarDni(dni);

                if (!validado) 
                {
                    Console.SetCursorPosition(20, 7);
                    Console.WriteLine("Ingrese los datos correctamente por favor");
                    Console.ReadKey();
                }
            }

            Console.SetCursorPosition(2, 9);
            Console.Write(nombreP);

            Console.SetCursorPosition(20, 9);
            nomb = Console.ReadLine();

            if (num == 2)
            {

                Console.SetCursorPosition(2, 11);
                Console.Write($"   PRECIO { nom}: ");

                Console.SetCursorPosition(20, 11);
                precio = int.Parse(Console.ReadLine());
            }

            Logica.AgregarDatos(dni, nomb, precio, num);

            Console.SetCursorPosition(2, 20);
            Console.WriteLine($"Se guardo correctamente {pron} nuevo {nom} ...");
            Console.ReadKey();

            //Limpia despues de la operacion
            Console.SetCursorPosition(0, 7);
            Console.WriteLine("                                                         ");
            Console.WriteLine("                                                         ");
            Console.WriteLine("                                                         ");
            Console.WriteLine("                                                         ");
            Console.WriteLine("                                                         ");
            Console.WriteLine("                                                         ");
            Console.WriteLine("                                                         ");
            Console.WriteLine("                                                         ");
            Console.WriteLine("                                                         ");
            Console.WriteLine("                                                         ");
            Console.WriteLine("                                                         ");
            Console.WriteLine("                                                         ");
            Console.WriteLine("                                                         ");
            Console.WriteLine("                                                         ");

        }

        public static void OperacionReporte(int dato)
        {
            string nom ="";
            int num;
            
            if (dato == 0)
            {
                nom = "DOCENTE";
            }
            else if (dato == 1)
            {
                nom = "ESTUDIAMTE";
            }
            else if (dato == 2)
            {
                nom = "CURSO";
            }

            Console.SetCursorPosition(20, 7);
            Console.WriteLine($" DNI/CODIGO    {nom}");
            
            num = Logica.MostrarReporte(dato);
            Console.SetCursorPosition(22, 8);
            Console.WriteLine($"{num}    uwu");

            //Limpia despues de la operacion
            Console.SetCursorPosition(0, 7);
            Console.WriteLine("                                                         ");
            Console.WriteLine("                                                         ");
            Console.WriteLine("                                                         ");
            Console.WriteLine("                                                         ");
            Console.WriteLine("                                                         ");
            Console.WriteLine("                                                         ");
            Console.WriteLine("                                                         ");
            Console.WriteLine("                                                         ");
            Console.WriteLine("                                                         ");
            Console.WriteLine("                                                         ");
            Console.WriteLine("                                                         ");
            Console.WriteLine("                                                         ");
            Console.WriteLine("                                                         ");
            Console.WriteLine("                                                         ");
        }

        public static void OperacionAsistencia()
        {

        }
    }
}
