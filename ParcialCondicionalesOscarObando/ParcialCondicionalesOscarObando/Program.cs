using System;

namespace ParcialCondicionalesOscarObando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char sexo = ' ';
            string ingles = " ";
            int edad = 0, digito = 0;
            char grupo = ' ';

            Console.WriteLine("Ingresar Sexo. M: masculino.  F:femenino");
            sexo = Convert.ToChar (Console.ReadLine());

            Console.WriteLine("Ingresar Edad");
            edad = int.Parse (Console.ReadLine());

            Console.WriteLine("Ingresar Último Dígito Del Documento De Identidad");
            digito = int.Parse (Console.ReadLine());

            switch (grupo)
            {
                case 'M':
                    if (edad >= 18 && edad <= 22)
                    {
                        if (digito == 1 && digito == 5 && digito == 9)
                        {
                            Console.WriteLine("Grupo A");
                        }
                    }

                    if (edad > 23 && edad < 26 && digito == 2 && digito == 6)
                    {
                        Console.WriteLine("Grupo B");
                    }

                    if (edad == 15)
                    {
                        Console.WriteLine("Manejo De Ingles: Si , No.");
                    }
                    break;

                case 'F':

                   if (edad >= 16 && edad <= 20 && digito == 0 && digito == 4 && digito == 8)
                   {
                        Console.WriteLine("Grupo A");
                   }

                   if (edad >= 21 && edad <= 25 && digito == 3 && digito == 7)
                   {
                        Console.WriteLine("Grupo B");
                   }

                    if (edad == 15)
                    {
                        Console.WriteLine("Manejo De Ingles: Si , No.");
                     }

                    break;
               
                default:
                    Console.WriteLine("Grupop D");
                    break;
            }



            

        }
    }
}
