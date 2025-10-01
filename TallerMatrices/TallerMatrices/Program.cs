namespace TallerMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Taller Matrices
            /*Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por 
              pantalla la suma de los elementos de cada columna. 

            int[,] matriz = new int[10, 20];
            int[] sumaColumnas = new int[20];

            Console.WriteLine("Ingrese los elementos de la matriz (10 filas y 20 columnas):");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.Write($"Elemento [{i + 1},{j + 1}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                    sumaColumnas[j] += matriz[i, j];
                }
            }
            Console.WriteLine($"suma de cada columna:");
            for (int j = 0; j < 20; j++)
            {
                Console.WriteLine($"Columna {j + 1}: {sumaColumnas[j]}");
            }
            Console.ReadLine();

            //ahora con random 

            int[,] matriz = new int[10, 20];
            int[] sumaColumnas = new int[20];
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    matriz[i, j] = rand.Next(1, 101); // Números aleatorios entre 1 y 100
                    //mostrar la matriz por filas y columnas
                    Console.Write($"{matriz[i, j]} |"); // Formateo para mejor visualización
                    sumaColumnas[j] += matriz[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"suma de cada columna:");
            for (int j = 0; j < 20; j++)
            {
                Console.WriteLine($"Columna {j + 1}: {sumaColumnas[j]}");
            }
            */


            /* Desarrollar un programa que crea una matriz de n filas * m columnas, el usuario ingresa 
               caracteres en cada posición de la matriz hasta llenarla. El programa debe intercambiar la 
               primera fila con la última fila de la matriz. Al final se debe imprimir la matriz original, y la 
               matriz con el intercambio de filas.*/

            int n = 0;
            int m = 0;
            char[,] matriz = new char[n, m];

            Console.Write("Ingrese el número de filas que desee ingresar: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de columnas que desee ingresar: ");
            m = int.Parse(Console.ReadLine());

            matriz = new char[n, m];
            Console.WriteLine("Ingrese los caracteres para llenar la matriz:");
 

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Elemento [{i + 1},{j + 1}]: ");
                    matriz[i, j] = char.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Matriz Original:");
            Console.WriteLine(matriz);








        }
    }
}
