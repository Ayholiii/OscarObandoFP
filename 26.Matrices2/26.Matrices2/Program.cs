namespace _26.Matrices2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*26. Escribe un programa que realice la suma de dos matrices de dimensiones 2x3. 

                  Requisitos del programa: 

                   1. Solicita al usuario que ingrese los elementos de la primera matriz de 2 filas y 3 columnas. 
                   2. Solicita al usuario que ingrese los elementos de la segunda matriz de las mismas dimensiones (2x3). 
                   3. Calcula la matriz suma, resultado de sumar cada elemento correspondiente de las dos matrices. 
                   4. Muestra la matriz resultante de la suma en formato de matriz (2 filas, 3 columnas). 
            */
            int filas = 2;
            int filas2 = 2;
            int columnas = 3;
            int[,] matriz1 = new int[filas, columnas];
            int[,] matriz2 = new int[filas2, columnas];
            int[,] matrizSuma = new int[filas, columnas];
            Console.WriteLine("Ingrese los elementos de la primera matriz (2x3):");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Elemento [{i + 1},{j + 1}]: ");
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Ingrese los elementos de la segunda matriz (2x3):");
            for (int i = 0; i < filas2; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Elemento [{i + 1},{j + 1}]: ");
                    matriz2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            // Sumar las dos matrices
            Console.WriteLine(
                "Matriz resultante de la suma:");
            for (int i = 0; i < filas; i++)
                {
                for (int j = 0; j < columnas; j++)
                {
                    matrizSuma[i, j] = matriz1[i, j] + matriz2[i, j];
                    Console.Write(matrizSuma[i, j] + "\t");
                }
                Console.WriteLine();
            }
                


        }

    }
}
