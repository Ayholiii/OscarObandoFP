namespace _18.DoWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*18. Algoritmo que le pida a un grupo de usuarios su nombre, número de cuenta y saldo; para cada usuario se debe hacer lo siguiente: 
                   1. Si el saldo es mayor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y “Es apto para el crédito” 
                   2. Si el saldo es menor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y “No es apto para el crédito” 
                   El algoritmo debe permitir preguntar la información de usuarios, hasta que se le indique que ya no se desea preguntar más. 
                   Además, el algoritmo debe permitir mostrar el número de usuarios a los que se le pregunto por la información, y debe mostrar el promedio de los saldos. */
            
            string nombre, numeroCuenta, opcion;
            double saldo, sumaSaldos = 0;
            int contadorUsuarios = 0;
            
            do
            {
                Console.Write("Ingrese el nombre del usuario: ");
                nombre = Console.ReadLine();
                Console.Write("Ingrese el número de cuenta: ");
                numeroCuenta = Console.ReadLine();
                Console.Write("Ingrese el saldo: ");
                saldo = Convert.ToDouble(Console.ReadLine());
                sumaSaldos += saldo;
                contadorUsuarios++;
                if (saldo > 3000000)
                {
                    Console.WriteLine($"Usuario: {nombre}, Número de cuenta: {numeroCuenta}, Saldo: {saldo}, Es apto para el crédito");
                }
                else
                {
                    Console.WriteLine($"Usuario: {nombre}, Número de cuenta: {numeroCuenta}, Saldo: {saldo}, No es apto para el crédito");
                }
                Console.Write("¿Desea ingresar otro usuario? (s/n): ");
                opcion = Console.ReadLine().ToLower();
            } while (opcion == "s");
            double promedioSaldos = sumaSaldos / contadorUsuarios;
            Console.WriteLine($"Número de usuarios ingresados: {contadorUsuarios}");
            Console.WriteLine(
                $"Promedio de saldos: {promedioSaldos}");
           
        }
    }
}
