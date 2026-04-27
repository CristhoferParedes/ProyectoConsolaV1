using System.Reflection.Emit;

namespace ProyectoConsola
{
    public class Logica
    {
        static int aumento_docente = 0;
        static int aumento_estudiante = 0;
        static int aumento_curso = 0;

        static int?[] num_docente = new int?[15];
        static string[] nom_docente = new string[15];

        static int[] num_estudiante = new int[15];
        static string[] nom_estudiante = new string[15];

        static int[] num_curso = new int[15];
        static string[] nom_curso = new string[15];
        static int[] pre_curso = new int[15];

        static int x;

        public static bool ValidarDni(int num)
        {
            return num >= 10000000 && num <= 99999999;
        }

        public static void AgregarDatos(int dato, string dato2, int dato3, int index)
        {

            if (index == 0)
            {
                num_docente[aumento_docente] = dato;
                nom_docente[aumento_docente] = dato2;
                aumento_docente++;

            }
            else if (index == 1)
            {
                num_estudiante[aumento_estudiante] = dato;
                nom_estudiante[aumento_estudiante] = dato2;
                aumento_estudiante++;

            }
            else if (index == 2)
            {
                num_curso[aumento_curso] = dato;
                nom_curso[aumento_curso] = dato2;
                pre_curso[aumento_curso] = dato3;
                aumento_curso++;
            }
        }  
            

        public static void MostrarReporte(int dato)
        {
            for (x = 0;x < num_docente.Length; x++)
            {
                switch (dato)
                {
                    case 0:                     
                        Console.SetCursorPosition(22, (8 + x));
                        Console.WriteLine($"{ num_docente[x]}    {nom_docente[x]}" );
                        break;
                    case 1:
                        Console.SetCursorPosition(22, (8 + x));
                        Console.WriteLine($"{num_estudiante[x]}    {nom_estudiante[x]}");
                        break;
                    case 2:
                        Console.SetCursorPosition(22, (8 + x));
                        Console.WriteLine($"{num_curso[x]}    {nom_curso[x]}    {pre_curso[x]}");
                        break;
                    default:
                        break;   
                }
            }
        }

        public static void MostarAsistencia()
        {
            //string[] marcado = { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", };
            string[] marcado = new string[15];
            int index = 0;
            ConsoleKey tecla;
            int i;
            bool cambio = true;

            do
            {
                for (i = 0; i < marcado.Length; i++)
                {
                    if (cambio)
                    {
                        marcado[i] = "-";
                        if (i == 15) cambio = false;
                    }
                    
                    
                    if (i == index)
                    {
                        Console.SetCursorPosition(10, (7 + i));
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($" {marcado[i]}   {nom_docente[i]}");
                        Console.ResetColor();

                    }
                    else
                    {
                        Console.SetCursorPosition(10, (7 + i));
                        Console.WriteLine($" {marcado[i]} ");
                    }
                }

                tecla = Console.ReadKey(true).Key;

                if (tecla == ConsoleKey.DownArrow)
                {
                    index++;
                    if (index > marcado.Length - 1) index = 0;
                }
                else if (tecla == ConsoleKey.UpArrow)
                {
                    index--;
                    if (index < 0) index = marcado.Length - 1;
                }
                
                if (tecla == ConsoleKey.Enter)
                {
                    marcado[index] = "A";
                }
                else if (marcado[index] == "A")
                {
                    marcado[index] = "-";
                }

            } while (tecla != ConsoleKey.Escape);

        }
    }
}
