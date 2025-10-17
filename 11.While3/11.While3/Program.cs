namespace _11.While3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que pida números enteros positivos y los sume, hasta que se ingrese un número entero negativo. Se debe mostrar por pantalla el total de la suma de los números ingresados. 

            int suma = 0;
            int numero;
            
            while (true)
            {
                Console.Write("Ingrese un número entero positivo (o un número negativo para finalizar): ");
                numero = int.Parse(Console.ReadLine());
                if (numero < 0)
                {
                    break;
                }
                suma += numero;
            }
            Console.WriteLine($"La suma total de los números ingresados es: {suma}");


        }
    }
}
