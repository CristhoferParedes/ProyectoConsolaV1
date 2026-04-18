
using System;

namespace ProyectoConsola
{
    public class Interfaz
    {
        public static int MenuPrincipal()
        {
            string[] opciones = { "REGISTRAR", "ASISTENCIA", "REPORTES", "SALIR"};
            int index = 0;
            ConsoleKey tecla;

            do
            {
                Console.SetCursorPosition(2, 4);
                Console.WriteLine("                     ");
                Console.WriteLine("                     ");
                Console.WriteLine("                     ");
                Console.WriteLine("                     ");

                Console.SetCursorPosition(5, 10);
                Console.Write("                                 ");

                Console.SetCursorPosition(0, 25);
                Console.WriteLine(" -------------------------------------------------------------- ");

                Console.SetCursorPosition(0, 0);

                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(" -------------------------------------------------------------- ");
                Console.WriteLine("                 SISTEMA DE GESTION DE ASISTENCIAS              ");
                Console.WriteLine(" -------------------------------------------------------------- ");
                Console.ResetColor();

                

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

                Console.WriteLine();

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
                Console.SetCursorPosition(2, 7);
                Console.WriteLine("                                        ");
                Console.WriteLine("                                        ");
                Console.WriteLine("                                        ");

                for (int i = 0; i < opciones.Length; i++)
                {
                    if (i == index)
                    {
                        Console.SetCursorPosition(2, (4 + i));
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($" {opciones[i]} ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.SetCursorPosition(2, (4 + i));
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

            Console.SetCursorPosition(2, 4);
            Console.WriteLine("                     ");
            Console.WriteLine("                     ");
            Console.WriteLine("                     ");
            Console.WriteLine("                     ");


            

            return index;
        }

        public static void MenuDocente()
        {
            Console.SetCursorPosition(5, 7);
            Console.Write("DNI DOCENTE:   ");
            Console.SetCursorPosition(20, 7);
            Console.ReadLine();

            Console.SetCursorPosition(2, 9);
            Console.Write("NOMBRE DOCENTE:   ");
            Console.SetCursorPosition(20, 9);
            Console.ReadLine();

        }
    }
}
