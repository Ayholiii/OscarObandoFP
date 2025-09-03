namespace _14.While6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un algoritmo que le pida al usuario ingresar por teclado números enteros al azar. Al usuario le corresponde ingresar la cantidad de números que va a introducir.  
                El algoritmo debe escribir en pantalla: 
                1. La cantidad de números introducidos que son mayores que 0 
                2. La cantidad de números introducidos menores que 0  
                3. La cantidad de números iguales a 0. */

            int num = 0, cantidad = 0, contador = 1, mayor = 0, menor = 0, igual = 0;

            //contador inicia en 1 o 0 depende del caso, pero why??????????, creo que ya aileen me excplico :P

            Console.WriteLine("ingrese la cantidad de números que desea ingresar");
            cantidad = int.Parse(Console.ReadLine());

            while (contador <= cantidad)
            {
                Console.WriteLine("Ingrese un número");
                num = int.Parse(Console.ReadLine());

                if (num == 0)
                {
                    igual++;
                }

                if (num < 0)
                {
                    menor++;
                }

                if (num > 0)
                {
                    mayor++;
                }
                contador++;
            }

            Console.WriteLine($"Números Mayores : {mayor}");
            Console.WriteLine($"Números menores : {menor}");
            Console.WriteLine($"Números iguales : {igual}");





        }
    }
}
