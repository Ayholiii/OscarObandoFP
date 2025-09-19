using Microsoft.Win32;
using System.Reflection;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

/*3.Dados dos números enteros ingresados por teclado: b que es la base y 
    e que es el exponente, se requiere calcular el resultado de la 
    potenciación.  
    Ejemplo: b=2, e=5 -> 25=2*2*2*2*2= 32 
    Mostrar por pantalla el resultado de la potenciación. 
    Seguir pidiendo por teclado la base y el exponente y realizar la 
    potenciación correspondiente, hasta que el usuario ingrese por teclado 
    el carácter de escape ‘n’ 

int baseNum = 0;
int exponente = 0;
int resultado = 1;
string continuar = "";
do
{
    Console.WriteLine("ingrese la base");
    baseNum = int.Parse(Console.ReadLine());
    Console.WriteLine("ingrese el exponente");
    exponente = int.Parse(Console.ReadLine());
    for (int i = 1; i <= exponente; i++)
    {
        resultado = resultado * baseNum;
    }
    Console.WriteLine($"el resultado de la potenciación es: {resultado}");
    Console.WriteLine("desea continuar calculando una potenciación: S: si - N: no");
    continuar = Console.ReadLine().ToLower();
    resultado = 1;
} while (continuar == "s");*/

/*4.Un entrenador le ha propuesto a un atleta recorrer una ruta de cinco
    kilómetros durante 10 días, para determinar si es apto para la prueba de
    5 kilómetros.Para considerarlo apto debe cumplir las siguientes
    condiciones: 
    - Que en ninguna de las pruebas haga un tiempo mayor a 20 minutos.
    - Que al menos en una de las pruebas realice un tiempo menor de 15
      minutos.
    - Que su promedio sea menor o igual a 18 minutos.
    Diseñar un algoritmo para registrar los datos y decidir si es apto para la
    competencia.*/
/*  int dias = 1;
  int tiempo = 0;
  int acumulador = 0;
  bool mayor20 = false;
  bool menor15 = false;
  do
  {
      Console.WriteLine($"ingrese el tiempo del día {dias} en minutos");
      tiempo = int.Parse(Console.ReadLine());
      if (tiempo > 20)
      {
          mayor20 = true;
      }
      if (tiempo < 15)
      {
          menor15 = true;
      }
      acumulador = acumulador + tiempo;
      dias++;
  } while (dias <= 10);

  double promedio = acumulador / 10.0;   
  if (mayor20 == false && menor15 == true && promedio <= 18)
  {
      Console.WriteLine("el atleta es apto para la competencia");
  }
  else
  {
      Console.WriteLine("el atleta no es apto para la competencia");
  }
*/

/*5. Se aplicó una encuesta a n personas solicitando su opinión sobre el 
     tema del servicio militar obligatorio para las mujeres. Las opciones de 
     respuesta fueron: a favor, en contra y no responde. Se solicita un 
     algoritmo que calcule qué porcentaje de los encuestados marcó cada 
     una de las respuestas. */



/*int personas = 0;
  int aFavor = 0;
  int enContra = 0;
  int noResponde = 0;
  string respuesta = "";

  Console.WriteLine("Ingrese la cantidad de personas encuestadas:");
  personas = int.Parse(Console.ReadLine());

  int total = personas; // total inicial

  do
  {
      Console.WriteLine("Servicio militar obligatorio para las mujeres:");
      Console.WriteLine("F: A Favor - C: En Contra - N: No Responde");
      respuesta = Console.ReadLine().ToLower();

      if (respuesta == "f")
      {
          aFavor++;
      }
      else if (respuesta == "c")
      {
          enContra++;
      }
      else if (respuesta == "n")
      {
          noResponde++;
      }

      personas--;

  } while (personas > 0);

  //  porcentajes
  Console.WriteLine("nResultados:");
  Console.WriteLine("A Favor: " + (aFavor * 100 / total) + "%");
  Console.WriteLine("En Contra: " + (enContra * 100 / total) + "%");
  Console.WriteLine("No Responde: " + (noResponde * 100 / total) + "%");
*/


/*6. Realizar un algoritmo que lea 40 números e imprima en pantalla cuántos 
de esos números son positivos, cuántos negativos, cuántos son neutros 
(0); además que imprima por pantalla la sumatoria de los números 
positivos y la de los negativos. 
*/

         /* int numero = 0;
            int positivos = 0;
            int negativos = 0;
            int neutros = 0;
            int sumaPositivos = 0;
            int sumaNegativos = 0;
            int contador = 1;
            int contadora = 1;
            int contado = 1;
            int buscar = 1;
            do
            {
                Console.WriteLine("ingrese un número");
                numero = int.Parse(Console.ReadLine());
                if (numero > 0)
                {
                    positivos++;
                    sumaPositivos = sumaPositivos + numero;
                    contador++;
                }
                else if (numero < 0)
                {
                    negativos++;
                    sumaNegativos = sumaNegativos + numero;
                    contadora++;
                }
                else
                {
                    neutros++;
                    contado++;
                }
                buscar++;
            } while (buscar <= 40);
            */


        }
}
}
