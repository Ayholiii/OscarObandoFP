namespace _10.While2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10. Crear un algoritmo que permita calcular la factorial de un número dado por el usuario. (5! = 1*2*3*4*5)
            int acumulador = 1, contador = 1, numero = 0;

            Console.WriteLine("escriba un Número para poder calcular el factorial:");
            numero = int.Parse (Console .ReadLine());

            while (contador <= numero)
            {
                acumulador = acumulador * contador;
                Console.WriteLine($"contador: {contador} - factorial: {acumulador}");
                contador++;
            }

            Console.WriteLine($"El Factorial del Número {numero} es: {acumulador}");


            
        }
    }
}
