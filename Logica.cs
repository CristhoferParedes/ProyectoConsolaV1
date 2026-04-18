namespace ProyectoConsola
{
    public class Logica
    {
        public static void ValidarDni()
        {
            int num = 12345678;
            int[] dni = new int[5];
            bool valido = false;

            if (num > 9999999)
            {
                for (int i = 0; i < dni.Length; i++) 
                {
                    if (num == dni[i])
                    {
                        valido = true;
                        break;
                    }
                    
                }

                dni[0] = num;
            }
        }
    }
}
