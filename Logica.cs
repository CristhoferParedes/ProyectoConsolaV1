namespace ProyectoConsola
{
    public class Logica
    {
        static int aumento_docente = 0;
        static int aumento_estudiante = 0;
        static int aumento_curso = 0;

        static int[] num_docente = new int[5];
        static string[] nom_docente = new string[5];

        static int[] num_estudiante = new int[5];
        static string[] nom_estudiante = new string[5];

        static int[] num_curso = new int[5];
        static string[] nom_curso = new string[5];
        static int[] pre_curso = new int[5];

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
            

        public static int MostrarReporte(int dato)
        {
            for (x = 0;x < num_docente.Length; x++)
            {
                switch (dato)
                {
                    case 0:
                        return num_docente[x];
                    case 1:
                        return num_estudiante[x];
                    case 2:
                        return num_curso[x];
                    default:
                        return 0;
                }
            }

            return 0;

        }
    }
}
