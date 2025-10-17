namespace _16.while8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*16. Escribe un algoritmo en el que el ordenador elija un número aleatorio entre 1 y 100. El usuario debe adivinar el número, y el programa debe decirle si su intento es demasiado alto, demasiado bajo o correcto. Usa un ciclo while para seguir pidiendo intentos hasta que el usuario adivine el número. *
             */
             
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);
            int intento = 0;
            Console.WriteLine("Adivina el número entre 1 y 100:");
                while (intento != numeroSecreto)
            {
                intento = int.Parse(Console.ReadLine());
                if (intento < numeroSecreto)
                {
                    Console.WriteLine("Demasiado bajo. Intenta de nuevo:");
                }
                else if (intento > numeroSecreto)
                {
                    Console.WriteLine("Demasiado alto. Intenta de nuevo:");
                }
                else
                {
                    Console.WriteLine("¡Correcto! Has adivinado el número.");
                }
            }
                Console.WriteLine(
                    "Fin del juego.");


        }
    }
}
