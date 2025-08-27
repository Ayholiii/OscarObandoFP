namespace _8.TallerCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Taller Condicionales Repaso Parcial

            /*1. Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1, 
            numero2, numero3 respectivamente. El algoritmo debe comprobar si los números son 
            diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en 
            pantalla los números de menor a mayor.  
            Si hay números iguales, el algoritmo debe mostrar un mensaje indicando que se deben 
            ingresar números diferentes. */

            int num1 = 0, num2 = 0, num3 = 0, mayor, menor, medio;

            Console.WriteLine("Ingrese El Núnmero 1:");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese El Número 2:");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese El Número 3:");
            num3 = Int32.Parse(Console.ReadLine());

            if (num1 != num2 && num1 != num3 && num2 != num3)
            {
                if (num1 > num2)
                {
                    if (num1 > num3)
                    {
                        mayor = num1;
                        if (num2 < num3)
                        {
                            Console.WriteLine($"De mayor a menor, los numeros son {num1}, {num3}, {num2}");
                        }
                        else
                        {
                            Console.WriteLine($"De mayor a menor, los numeros son {num1}, {num2}, {num3}");

                        }
                    }
                    else
                    {
                        Console.WriteLine($"De mayor a menor, los numeros son {num3}, {num1}, {num2}");

                    }
                }
                else
                {
                    if (num2 > num3)
                    {
                        mayor = num2;
                        if (num1 < num3)
                        {
                            Console.WriteLine($"De menor a mayor, los numeros son {num2}, {num3}, {num1}");
                        }
                        else
                        {
                            Console.WriteLine($"De menor a mayor, los numeros son {num1}, {num2}, {num3}");
                        }
                    }
                    else
                    {
                        mayor = num3;
                        Console.WriteLine($"De menor a mayor, los numeros son {num3}, {num2}, {num1}");
                    }
                }

            }
            else
            {
                Console.WriteLine("Los Números deben ser diferentes");
            }
        }
    }
}
