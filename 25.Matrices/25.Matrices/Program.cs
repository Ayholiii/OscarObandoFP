namespace _25.Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos Bidimensionales - Matrices

            int[,] numeros = new int[2, 2];

            //string[,] nombres = new string[3, 2];

           // char[,] caracteres = new char[2, 4];

            bool[,] banderas = new bool[2, 5];

            object[,] objetos = new object[2, 5];

            // Asignacion de valores con f, c

            numeros[0, 0] = 15;
            numeros[0, 1] = 25;
            numeros[1, 0] = 32;
            numeros[1, 1] = 4;

            // numeros [1, 2] = 7; error por índices fuera de los rangos

            //Recuperar datos almacenados en una posición

            Console.WriteLine($"valor almacenado en la posici[on con índices 1,0: {numeros[1, 0]} ");


            //Declaración e inicialización de matrices con valores por defect

            string[,] apellidos =
            {
                {"Chica", "López", "Álvarez" },
                {"Patiño","Ciro","Castaño" },
                {"Duque","Carmona","Castaño" }
            };

            //Recorrer Para Almacenar Datos 

           /* string[,] nombres = new string[3, 2];

            for (int i = 0; i < 3; i++) // recorre filas
            {

                for (int j = 0; j < 2; j++) // recorre columnas
                {

                    Console.WriteLine($"Ingrese el nombre para la posición {i},{j}: ");

                    nombres[i, j] = Console.ReadLine();

                }

            }

            //recorrer para recuperar datos

            for (int i = 0; i < nombres.GetLength(0); i++) // .getLength(0) devuelve el número de filas de la matriz
            {
                for (int j = 0; j < nombres.GetLength(1); j++) // .getLength(1) devuelve el número de columnas
                {
                    Console.WriteLine($"{nombres[i, j]} |");
                }
            }*/

            char[,] caracteres = new char[2, 4];

            for (int i = 0; i < 2; i++) // recorre filas
            {

                for (int j = 0; j < 4; j++) // recorre columnas
                {

                    Console.WriteLine($"Ingrese un caracter para la posición {i},{j}: ");

                    caracteres[i, j] = Convert.ToChar(Console.ReadLine());

                }

            }

            //recorrer para recuperar datos

            for (int i = 0; i < caracteres.GetLength(0); i++) // .getLength(0) devuelve el número de filas de la matriz
            {
                for (int j = 0; j < caracteres.GetLength(1); j++) // .getLength(1) devuelve el número de columnas
                {
                    Console.Write($"{caracteres[i, j]} |");
                }
            }

        }
    }
}
