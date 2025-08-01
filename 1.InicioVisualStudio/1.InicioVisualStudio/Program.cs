namespace _1.InicioVisualStudio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Esta es la declaración e inicialización de una variable
            string nombre="daniel";
            const string iva = "19%";

            Console.Write("Hola, " + nombre + "\n");
            Console.Write("\tbienvenido a la clase de programacion");
            nombre = "roberto";
            Console.Write("\n" + nombre);
            //iva = "20%"; NO se puede cambiar el valor de una constante

            //Tipos de datos
            byte dato1 = 255;
            int dato2 = 202321;
            long dato3 = 9202125235;
            double dato4 = 326.625;
            char dato5 = '$'; //Puede almacenar un solo caracter
            bool dato6 = false; //Almacena true o false
            object dato7 = new Program();

        }
    }
}
