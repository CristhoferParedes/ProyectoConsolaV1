namespace ProyectoConsola
{
    public class Logica
    {
        public static bool ValidarDni(int num)
        {
            
            //int[] dni = new int[5];
            bool valido = false;
           
            if ( num > 9999999)
            {
                    valido = true;                 
            }     
            
            return valido;
        }
    }
}
