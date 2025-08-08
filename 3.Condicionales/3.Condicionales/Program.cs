namespace _3.Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Primer Ejercicio

/*Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos.*/


// CONDICIONAL SIMPLE
string nombre = "";
int sueldo = 0;

Console. WriteLine("Ingrese el nombre");
nombre = Console .ReadLine(); //Todo lo que leo desde la consola
//Llega como un STRING
Console.WriteLine(nombre);
Console.WriteLine("Ingrese el sueldo");
sueldo = Convert.ToInt32(Console.ReadLine());

if (sueldo > 3000)
{
    Console.WriteLine($"La persona {nombre}, debe abonar impuestos");
}


}
}
}
