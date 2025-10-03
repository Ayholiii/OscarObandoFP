namespace _29.Modular1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] multiplosDe5 = new int[CapturarColumnas(), CapturarColumnas()];
        }

        static int CapturarFilas ()
        {
            Console.WriteLine("Ingrese la cantidad de filas para la matriz:");
            int filas = int.Parse(Console.ReadLine());
            return filas;
        }

        static int CapturarColumnas()
        {
            Console.WriteLine("Ingrese la cantidad de Columnas para la matriz:");
            int columnas = int.Parse(Console.ReadLine());
            return columnas;
        }

        static int[,] LlenarMatriz(int[,] matriz)
        {
            return matriz;
        }
    }
}
