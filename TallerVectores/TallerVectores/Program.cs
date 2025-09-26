namespace TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Taller Vectores

            /*1. Escribir un algoritmo que permita llenar un vector[15] con números enteros, y luego 
                 encuentre y muestre el valor máximo y mínimo de los números ingresados. 

            int[] vector = new int[15];
            int maximo;
            int minimo;

            console.WriteLine("Ingrese en cada posición un número DIFERENTE");

            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write($"Ingrese un número en la posición {i + 1}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            maximo = vector[0];
            minimo = vector[0];

            for (int i = 1; i < vector.Length; i++)
            {
                if (vector[i] > maximo)
                {
                    maximo = vector[i];
                }
                if (vector[i] < minimo)
                {
                    minimo = vector[i];
                }
            }
            Console.WriteLine($"El valor máximo es: {maximo}");
            Console.WriteLine($"El valor mínimo es: {minimo}");
            */

            /*2. Escribe un algoritmo que permita ingresar caracteres en un vector, y luego invierta el 
                 orden de los elementos del vector. Se deben mostrar lo dos vectores.*/

            char[] vector = new char[5];
            char[] vectorInvertido = new char[5];

            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write($"Ingrese un carácter en la posición {i + 1}: ");
                vector[i] = char.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vector.Length; i++)
            {
                vectorInvertido[i] = vector[vector.Length - 1 - i];
            }

            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }

            for (int i = 0; i < vectorInvertido.Length; i++)
            {
                Console.WriteLine(vectorInvertido[i]);
            }







        }
    }
}
