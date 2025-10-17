namespace _6.Condicional_Multiple_Terciario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicional Multiple
/*6. Tiendas La Avenida desea desarrollar un programa que permita ingresar por teclado el monto de compra y el día de la semana, para saber:
Si el día es martes o jueves, se realizará un descuento del 15% por la compra. 
Si el día es lunes o miércoles, se realizará un descuento del 10% por la compra.
Si el día es viernes o sábado, se realizará un descuento del 20% por la compra.
Si es domingo no se realiza descuento.
Visualizar el día, el descuento y el total a pagar por la compra. */

float ValorCompra = 0, descuento = 0;
char dia = ' ';

Console.WriteLine("ingrese el valor de la compra");
ValorCompra = Single.Parse (Console.ReadLine());

Console.WriteLine("Ingrese el día de la semana: l:Lunes, m:martes, x:miércoles, j:jueves, v:viernes, s:sábado, d:domingo");
dia= Convert.ToChar(Console.ReadLine());

switch (dia)
{
    case 'l':
        descuento = ValorCompra * 0.1f;
        Console.WriteLine($"Hoy es Lunes, descuento: {descuento}, valor a pagar: {ValorCompra - descuento}");
        break;

    case 'm':
        descuento = ValorCompra * 0.15f;
        Console.WriteLine($"Hoy es Martes, descuento: {descuento}, valor a pagar: {ValorCompra - descuento}");
        break;

    case 'x':
        descuento = ValorCompra * 0.1f;
        Console.WriteLine($"Hoy es Miércoles, descuento: {descuento}, valor a pagar: {ValorCompra - descuento}");
        break;

    case 'j':
        descuento = ValorCompra * 0.15f;
        Console.WriteLine($"Hoy es Jueves, descuento: {descuento}, valor a pagar: {ValorCompra - descuento}"); 
        break;

    case 'v':
        descuento = ValorCompra * 0.2f;
        Console.WriteLine($"Hoy es Viernes, descuento: {descuento}, valor a pagar: {ValorCompra - descuento}"); 
        break;

    case 's':
        descuento = ValorCompra * 0.2f;
        Console.WriteLine ($"Hoy es Sábado, descuento: {descuento}, valor a pagar: {ValorCompra - descuento}"); 
        break;

    case 'd':
        descuento = ValorCompra * 0;
        Console.WriteLine($"Hoy es Domingo, descuento: {descuento}, valor a pagar: {ValorCompra - descuento}"); 
        break;

    default:
        Console.WriteLine("Ingrese un valor VALIDO"); 
        break;


}
            // Ejercicio en Clase
/*Diseñar un algoritmo que permita crear una calculadora básica capaz de realizar operaciones aritméticas entre dos números ingresados por el usuario. Las operaciones disponibles serán: suma, resta, multiplicación y división, las cuales se ejecutarán según la opción seleccionada por el usuario. 

  */
float num1 = 0, num2 = 0, resultado = 0;
            char operacion = ' ';
            Console.WriteLine("Ingrese el primer número:");
            
            num1 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            num2 = Single.Parse(Console.ReadLine());
            Console.WriteLine(
                "Seleccione la operación a realizar:\n" +
                "s: Suma\n" +
                "r: Resta\n" +
                "m: Multiplicación\n" +
                "d: División"
                );
            operacion = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(
                operacion switch
                {
                    's' => $"El resultado de la suma es: {num1 + num2}",
                    'r' => $"El resultado de la resta es: {num1 - num2}",
                    'm' => $"El resultado de la multiplicación es: {num1 * num2}",
                    'd' => num2 != 0 ? $"El resultado de la división es: {num1 / num2}" : "Error: División por cero no permitida.",
                    _ => "Operación no válida."
                }
            );
            Console.WriteLine(
                "Presione cualquier tecla para finalizar..."
            );
            Console.ReadKey();
            Console.WriteLine(
                "Fin del programa."
            );
         

        }
}
}
