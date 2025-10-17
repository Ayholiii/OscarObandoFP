namespace _20.For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*20. Un equipo de futbol jugó 30 partidos en el año, se desea crear un algoritmo que permita saber:   
El número de partidos perdidos  
El número de partidos empatados  
El número de partidos ganados  
El porcentaje de partidos perdidos  
El porcentaje de partidos empatados  
El porcentaje de partidos ganados */
            int partidosGanados = 0;
            int partidosPerdidos = 0;
            int partidosEmpatados = 0;
            int totalPartidos = 30;
            for (int i = 1; i <= totalPartidos; i++)
            {
                Console.WriteLine($"Ingrese el resultado del partido {i} (G=Ganado, P=Perdido, E=Empatado): ");
                string resultado = Console.ReadLine().ToUpper();
                switch (resultado)
                {
                    case "G":
                        partidosGanados++;
                        break;
                    case "P":
                        partidosPerdidos++;
                        break;
                    case "E":
                        partidosEmpatados++;
                        break;
                    default:
                        Console.WriteLine("Resultado inválido. Por favor ingrese G, P o E.");
                        i--; // Repetir el mismo partido
                        break;
                }
            }
            Console.WriteLine($"\nResultados del equipo de fútbol en el año:");
            Console.WriteLine($"Partidos Ganados: {partidosGanados} ({(partidosGanados * 100.0 / totalPartidos):F2}%)");
            Console.WriteLine($"Partidos Perdidos: {partidosPerdidos} ({(partidosPerdidos * 100.0 / totalPartidos):F2}%)");
            Console.WriteLine($"Partidos Empatados: {partidosEmpatados} ({(partidosEmpatados * 100.0 / totalPartidos):F2}%)");

        }
    }
}
