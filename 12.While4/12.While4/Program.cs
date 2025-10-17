namespace _12.While4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar algoritmo que permita obtener la suma de todos los números impares hasta el 99. 
            int numero = 1;
            int suma = 0;
            while (numero < 100)
            {
                suma += numero;
                numero += 2;
            }
            Console.WriteLine("La suma de los números impares hasta el 99 es: " + suma);

        }
    }
}
