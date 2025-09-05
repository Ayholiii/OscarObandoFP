namespace _17.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Algoritmo que genera y suma los 5 primeros números enteros

            /*int contador = 0, acumulador = 0;

            do
            {
                contador++;
                acumulador = acumulador + contador;
            } while (contador < 5);

            Console.WriteLine($"La suma de los 5 números enteros es: {acumulador}");*/

            //Algoritmo que solicita un número y genere su correspondiente tabla de multiplicar desde el 1 hasta el 10. Y así sucesivamente hasta que el usuario ya no desee continuar generando tablas de multiplicar. 

            int contador = 1, num = 0;
            string respuesta = "";

            do
            {

                Console.WriteLine("Ingrese un número para calcular su tabla de multiplicar");
                num = int.Parse(Console.ReadLine());

                do
                {
                    Console.WriteLine($"{num} x {contador} = {num * contador}");
                    contador++;

                } while (contador <= 10);

                Console.WriteLine("Desea generar una nueva tabla de mutíplicar: S:si N:no");

                respuesta = Console.ReadLine().ToLower();

                contador = 1;

            } while (respuesta == "s");


        }
    }
}
