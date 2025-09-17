namespace _22.Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos Unidimendionales
            //Vectores

            int[] numeros = new int[5];
            string [] nombres = new string[4];

            // Almacenar Datos 
            numeros[0] = 12;
            numeros[1] = 32;
            numeros[2] = 41;
            numeros[3] = 100;
            numeros[4] = 56;
            //numeros[5] = 0; NO se puede almacenar el dato porque la posición con índice 5 no EXISTE.

            //Recuperrar Datos
            Console.WriteLine($"El valor almacenado en la posición 4, con indice 3 es: {numeros[3]}");

            for ( int i = 0; i < 5; i++ )
            {
                Console.WriteLine($"ingrese el dato para posición {i+1}, con índice {i}:");
                numeros [i] = int.Parse(Console.ReadLine());

            }

            //Otras formas de declarar e inicializar vectores

            char[] caracteres = new char [] { 'a', 'b', 'c', 'd', 'e', 'f', 'g'};
            float[] numeros2 = { 0.3f, 1.5f, 2.5f, 4.5f, 0.0f };


            // Recorrer para Recuperar Datos Almacenados

            for (int i = 0; i<caracteres.Length; i++)
            {
                Console.WriteLine ($"P: {i+1} - I:{i}: {caracteres[i]}");
            }

            for (int i=0; i<numeros2.Length;i++)
            {
                Console.Write($"{numeros2[i]}  ");
            }


        }
    }
}
