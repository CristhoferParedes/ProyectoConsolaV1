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
                //escribe el menu principal
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

        public static int MenuSegundario()
        {
            string[] opciones = {"DOCENTE", "ESTUDIANTE", "CURSOS", "SALIR"};
            int index = 0;
            ConsoleKey tecla;

            do
            {
                Console.SetCursorPosition(0, 4);

                for (int i = 0; i < opciones.Length; i++)
                {
                    if (i == index)
                    {                    
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($" {opciones[i]} ");
                        Console.ResetColor();
                    }
                    else Console.WriteLine($" {opciones[i]} ");                   
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

            //se limpia cuando se cierra completamente o se seleciona una opcion en el submenu
            Console.SetCursorPosition(0, 4);
            Console.WriteLine("1                uwu                          1");
            Console.WriteLine("1                uwu                          1");
            Console.WriteLine("1                uwu                          1");
            Console.WriteLine("1                uwu                          1");
            Console.WriteLine("1                uwu                          1");
            Console.WriteLine("1                uwu                          1");
            Console.WriteLine("1                uwu                          1");
            Console.WriteLine("1                uwu                          1");
            Console.WriteLine("1                uwu                          1");


            return index;
        }

        public static void OperacionRegistar(int num)
        {
            int dni;
            bool validado = false;
            string nombreN = "";
            string nombreP = "";
            string nom = "";

            while (!validado)
            {
                

                //Limpia la seccion despues de escribir el dni , si es incorrecto
                Console.SetCursorPosition(20, 7);
                Console.WriteLine("                                      ");


                switch (num)
                {
                    case 0:
                        {
                            nom = "DOCENTE";
                            nombreN = $"     DNI {nom}: ";
                            nombreP = $"  NOMBRE {nom}: ";


                            break;
                        }
                    case 1:
                        {
                            nom = "ESTUDIANTE";
                            nombreN = $"  DNI {nom}: ";
                            nombreP = $"NOMBR {nom}: ";
                            break;
                        }
                    case 2:
                        {
                            nom = "CURSO";
                            nombreN = $"    CODIGO {nom}: ";
                            nombreP = $"    NOMBRE {nom}: ";
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
                    Console.WriteLine("Ingrese el dni correctamente por favor");
                    Console.ReadKey();
                }
            }

            Console.SetCursorPosition(2, 9);
            Console.Write(nombreP);
            Console.SetCursorPosition(20, 9);
            Console.ReadLine();

            if(num == 2)
            {

                Console.SetCursorPosition(2, 11);
                Console.Write($"   PRECIO { nom}: ");

                Console.SetCursorPosition(20, 11);
                Console.ReadLine();
            }

            Console.SetCursorPosition(2, 20);
            Console.WriteLine($"Se guardo correctamente el nuevo {nom} ...");
            Console.ReadKey();

            //Limpia despues de la operacion
            Console.SetCursorPosition(2, 20);
            Console.WriteLine("11                                              12");

            //limpia texto precio
            Console.SetCursorPosition(0, 11);
            Console.WriteLine("13                                              14");



        }
    }
}
