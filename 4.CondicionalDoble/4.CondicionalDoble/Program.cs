using System.ComponentModel.Design;
using System.Transactions;

namespace _4.CondicionalDoble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CONDICIONALES DOBLES O COMPUESTOS

            /*Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos.De */

            /*string nombre = "";
            int sueldo = 0;

            Console.WriteLine("Ingrese el nombre");
            nombre=Console.ReadLine();

            Console.WriteLine("Ingrese el Sueldo");
            sueldo = Int32.Parse(Console.ReadLine());

            if(sueldo >= 3000)
            {
             //verdadero
             Console.WriteLine($"la persona {nombre}, debe abonar impuestos");
            }
            else
            {
             //falso
             Console.WriteLine($"la persona {nombre}, NO abona impuestos");
            }*/


            //MayorDeEdad

            /*Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18, se debe mostrar el siguiente mensaje: “Bienvenido a mi sitio web".De lo contrario, mostrar el mensaje “No es apto para el contenido de este sitio web”.*/

            /*int edad = 0;

            Console.WriteLine("Por Favor Ingrese Su Edad");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Bienvenido a mi sitio web");
            }
            else
            {
                Console.WriteLine("no es apto para el contenido de este sitio web");*/




            //OperacionesEntreNúmeros 

            /*Crear un algoritmo que permita ingresar dos números, si el primer número es mayor al segundo número informar su suma y diferencia, en caso contrario informar el producto y la división del primer número respecto al segundo número. */

            double numero1 = 0f, numero2 = 0f;

            Console.WriteLine("Ingrese un número");
            numero1=double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un número DIFERENTE");
            numero2 = double.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine($"suma: {numero1+numero2}");
                Console.WriteLine($"resta: {numero1 - numero2}");
            }
            else
            {
                Console.WriteLine($"multiplicación: {numero1*numero2}");
                Console.WriteLine($"división: {numero2/numero1}");
            }
        }




    }
}

