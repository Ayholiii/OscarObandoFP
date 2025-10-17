namespace _30.Modular2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Algoritmo que muestre un menú con operaciones (+,-,*,/) y permita realizar la operación que el usuario ingrese por teclado. Si es suma o multiplicación, permitirle al usuario realizar estas operaciones con la cantidad de números que el desee ingresar. Si es división o resta solo dejar realizar la operación con dos números. 
 
             */
            Console.WriteLine("Seleccione la operación que desea realizar:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            string opcion = Console.ReadLine();

            Console.WriteLine(
                opcion switch
                {
                    "1" => Sumar(),
                    "2" => Restar(),
                    "3" => Multiplicar(),
                    "4" => Dividir(),
                    _ => "Opción no válida"
                });
            Console.WriteLine(
                "Presione una tecla para finalizar...");
            Console.WriteLine(
                Console.ReadKey());
            Console.WriteLine(
                "");
            static string Sumar()
            {
                double suma = 0;
                string entrada;
                do
                {
                    Console.WriteLine("Ingrese un número para sumar (o 'fin' para terminar):");
                    entrada = Console.ReadLine();
                    if (entrada.ToLower() != "fin" && double.TryParse(entrada, out double numero))
                    {
                        suma += numero;
                    }
                } while (entrada.ToLower() != "fin");
                return $"El resultado de la suma es: {suma}";
            }
            static string Restar()
            {
                Console.WriteLine("Ingrese el primer número:");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número:");
                double num2 = Convert.ToDouble(Console.ReadLine());
                double resultado = num1 - num2;
                return $"El resultado de la resta es: {resultado}";
            }
            static string Multiplicar()
            {
                double producto = 1;
                string entrada;
                do
                {
                    Console.WriteLine("Ingrese un número para multiplicar (o 'fin' para terminar):");
                    entrada = Console.ReadLine();
                    if (entrada.ToLower() != "fin" && double.TryParse(entrada, out double numero))
                    {
                        producto *= numero;
                    }
                } while (entrada.ToLower() != "fin");
                return $"El resultado de la multiplicación es: {producto}";
            }
            static string Dividir()
            {
                Console.WriteLine("Ingrese el dividendo:");
                double dividendo = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el divisor:");
                double divisor = Convert.ToDouble(Console.ReadLine());
                if (divisor == 0)
                {
                    return "Error: No se puede dividir por cero.";
                }
                double resultado = dividendo / divisor;
                return $"El resultado de la división es: {resultado}";

            }




        }

    }
}

