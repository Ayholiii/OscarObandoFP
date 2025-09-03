namespace _13.While5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un algoritmo que cuente cuántos números pares hay en un rango de números del 1 al número n. 

          
            {
                int CantidadPares = 0, contador = 1, rango = 1;

                Console.WriteLine("Ingrese un número : ");
                rango = int.Parse(Console.ReadLine());

                while (contador <= rango)
                {
                    if (contador % 2 == 0) // si es par
                    {
                        CantidadPares++;
                    }
                    contador++;
                }

                Console.WriteLine($"Cantidad de números pares entre 1 y {rango}, es: {CantidadPares}");

                //Otra Forma
            }
        }

    }
}

