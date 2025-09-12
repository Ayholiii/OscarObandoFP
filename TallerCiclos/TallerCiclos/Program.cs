using System.Reflection;

namespace TallerCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Algoritmo que permita calcular el promedio de calificaciones, el algoritmo 
                 le permitirá al usuario, introducir tantas calificaciones como así desee, 
                 en el momento en que seleccione que no desea continuar capturando 
                 calificaciones, el algoritmo debe presentar el promedio de las 
                 calificaciones capturadas previamente.

            double calificaciones = 0.0;
            double promedio = 0;
            string continuar = "";
            int veces = 1;
            double acumulador = 0.0;

            do
            {
                Console.WriteLine("ingrese su calificación");
                calificaciones = double.Parse(Console.ReadLine());

                acumulador = acumulador + calificaciones;

                promedio = acumulador / veces;

                Console.WriteLine($"su promedio es:{promedio}");


                Console.WriteLine("desea continuar calculando su promedio: S: si - N: no");
                continuar = Console.ReadLine().ToLower();

                veces++;

            } while (continuar == "s");*/

            /*2.Se requiere un algoritmo para mostrar por pantalla los divisores de un 
                número ingresado por teclado. 
                Tener en cuenta que dados dos números enteros a y b, se dice que b es 
                divisor de a si se cumple que al efectuar una división entera a/b el 
                residuo es 0, en C# utilizar el operador Mod para obtener el residuo de 
                una división de dos números. 
                Ejemplo: si se ingresa 6 por teclado, por pantalla se debe mostrar 6, 3, 
                2, 1 que son los divisores del número 6. 

            int numeroA = 0;
            int veces = 1;

            Console.WriteLine("ingrese un número para saber sus divisores");
            numeroA = int.Parse(Console.ReadLine());

            while (veces<=numeroA)
            {
                if (numeroA % veces == 0)
                { 
                 Console.WriteLine("divisores:");
                 Console.WriteLine(veces);
                }

                veces++;

            } */

            /**/



        }
    }
}
