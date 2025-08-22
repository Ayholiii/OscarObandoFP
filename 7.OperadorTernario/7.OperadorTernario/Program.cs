namespace _7.OperadorTernario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operador Terciario

            /* Escribe un programa que verifique si una persona es mayor de edad usando el operador ternario. Una persona mayor de edad tiene 18 años o más). 
            int edad = 0;

            Console.WriteLine("Ingrese La Edad:");
            edad=Int32.Parse(Console.ReadLine());

            Console.WriteLine(edad >= 18 ? "Es Mayor De Edad" : "NO Es Mayor De Edad" );*/


            /*Algoritmo que permita inngresar 3 números enteros diferentes, y muestre un mensaje diciendo cuál es el mayor*/

            int num1 = 0, num2 = 0, num3 = 0, mayor;

            Console.WriteLine("Ingrese El Núnmero 1:");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese El Número 2:");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese El Número 3:");
            num3 = Int32.Parse(Console.ReadLine());

            mayor = num1 > num2
                ? (num1 > num3 ? num1 : num3)
                : (num2 > num3 ? num2 : num3);

            Console.WriteLine($"El Número Mayor Es: {mayor}");

}
}
}
