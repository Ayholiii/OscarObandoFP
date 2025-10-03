namespace _28.ProgramaciónModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMensaje();
            MostrarMensajes("Soy Danielle");
            MostrarMensajes($"tengo {CalcularEdad()} años");
            MostrarMensajes($"Tengo {CalcularEdad(2025, 2007)}");
        }

        //Módulo 1 - Procedimiento sin parámetros

        static void MostrarMensaje()
        {
            Console.WriteLine("Bienvenido a la programación modular");
            MostrarMensajes("estoy siendo llamado desde MostrarMensaje()");
        }

        //Módulo 2 - 

        static void MostrarMensajes(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        //Módulo 3 - Función sin parámetros

        static int CalcularEdad ()
        {
            int edad = 2025 - 2007;
            return edad;
        }

        //Módulo 4 - Función con parámetros

        static int CalcularEdad(int AñoActual, int AñoNacimiento)
        {
            return AñoActual - AñoNacimiento;
        }
    }
}
