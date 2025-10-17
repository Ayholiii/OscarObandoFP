namespace _27.Matrices3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Desarrolla una aplicación que realice las siguientes tareas: 

  Solicita al usuario que ingrese las dimensiones de una matriz (número de filas y columnas). 
  Recorre la matriz y permite al usuario ingresar un número entero en cada posición. 
  Una vez cargada la matriz, el programa debe contar cuántos de los números ingresados son positivos, cuántos son negativos y cuántos son ceros. 
  Finalmente, muestra por pantalla los totales obtenidos para cada categoría (positivos, negativos y ceros). 
  */
            Console.WriteLine("Ingrese el número de filas de la matriz:");
            int filas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de columnas de la matriz:");
            int columnas = int.Parse(Console.ReadLine());
            int[,] matriz = new int[filas, columnas];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine($"Ingrese un número entero para la posición [{i},{j}]:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int positivos = 0;
            int negativos = 0;
            int ceros = 0;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (matriz[i, j] > 0)
                    {
                        positivos++;
                    }
                    else if (matriz[i, j] < 0)
                    {
                        negativos++;
                    }
                    else
                    {
                        ceros++;
                    }
                }
            }
            Console.WriteLine($"Total de números positivos: {positivos}");
            Console.WriteLine($"Total de números negativos: {negativos}");
            Console.WriteLine($"Total de ceros: {ceros}");

            Console.WriteLine(
                "Presione cualquier tecla para finalizar...");
            Console.ReadKey();

        }
    }
}
