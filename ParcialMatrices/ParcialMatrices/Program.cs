namespace ParcialMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parcial Matrices
            /*Gestión y análisis de notas en una matriz:
                Se dispone de una tabla con las notas de 10 estudiantes en 4 materias: Matemáticas, Física, Inglés y Sociales.

              Objetivo:
                Desarrollar un programa que permita ingresar, procesar y mostrar información estadística basada en las notas, cumpliendo con los siguientes requisitos:

              Especificaciones:

              Ingreso de datos:
               - Permitir al usuario ingresar por teclado las notas para cada estudiante y cada materia.
               - Las notas deben ser valores numéricos decimales (float o double) entre 0 y 5.
               - Validar que las notas ingresadas estén dentro del rango válido; en caso contrario, solicitar la nota nuevamente.

              Almacenamiento:
                Utilizar una matriz bidimensional de dimensiones 10 x 4, donde cada fila representa un estudiante y cada columna una materia (en el orden: Matemáticas, Física, Inglés, Sociales).

              Mostrar matriz:
                Al finalizar el ingreso, mostrar en pantalla la matriz completa de notas, con encabezados claros para estudiantes y materias, en un formato tabulado.

              Cálculo de promedios:
                Calcular y mostrar:
                    a) El promedio total de todas las notas de la matriz.
                    b) El promedio de las notas del estudiante número 9 (fila índice 8).
                    c) El promedio de las notas para cada materia (columna), mostrando cada resultado con el nombre de la materia correspondiente.

              Presentación de resultados:
                Incluir mensajes claros que indiquen qué promedio se está mostrando.

              Consideraciones adicionales:
                Asegúrese de validar las entradas para evitar datos fuera de rango o formatos inválidos.*/

            int numEstudiantes = 10;
            int numMaterias = 4;
            float sumaTotal = 0;
            float sumaEstudiante9 = 0;
            float promedioMatematicas;
            float promedioFisica;
            float promedioIngles;
            float promedioSociales;
            float promedioTotal;
            float promedioEstudiante9;            
            float[] sumaPorMateria = new float[numMaterias];
            float[] promedioPorMateria = new float[numMaterias];
            string[] materias = { "Matemáticas", "Física", "Inglés", "Sociales" };
            float[,] notas = new float[numEstudiantes, numMaterias];

            // Ingreso De Datos
            for (int i = 0; i< numEstudiantes; i++)
            {
                Console.WriteLine($"Ingrese las notas del estudiante {i + 1}:");
                for (int j = 0; j < numMaterias; j++)
                {
                    float nota;
                    do
                    {
                        Console.Write($"  {materias[j]}: ");
                        while (!float.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 5)
                        {
                            Console.WriteLine("    Nota inválida. Ingrese una nota entre 0 y 5.");
                            Console.Write($"  {materias[j]}: ");
                        }
                    } while (nota < 0 || nota > 5);
                    notas[i, j] = nota;
                    sumaTotal += nota;
                    if (i == 8)
                    {
                        sumaEstudiante9 += nota;
                    }
                    sumaPorMateria[j] += nota;
                }
            }

            // Matriz
            Console.WriteLine("\nMatriz de notas:");
            Console.Write("Estudiante|\t");
            for (int j = 0; j < numMaterias; j++)
            {
                Console.Write($"{materias[j]}|\t");
            }
            Console.WriteLine();
            for (int i = 0; i < numEstudiantes; i++)
            {
                Console.Write($"    {i + 1}|\t");
                for (int j = 0; j < numMaterias; j++)
                {
                    Console.Write($"{notas[i, j]}|\t");
                }
                Console.WriteLine();
            }
            // Cálculo de promedios

            promedioTotal = sumaTotal / (numEstudiantes * numMaterias);
            Console.WriteLine($"Promedio total de todas las notas: {promedioTotal}");
            promedioEstudiante9 = sumaEstudiante9 / numMaterias;
            Console.WriteLine($"Promedio del estudiante número 9: {promedioEstudiante9}");
            promedioMatematicas = sumaPorMateria[0] / numEstudiantes;
            promedioFisica = sumaPorMateria[1] / numEstudiantes;
            promedioIngles = sumaPorMateria[2] / numEstudiantes;
            promedioSociales = sumaPorMateria[3] / numEstudiantes;
            Console.WriteLine($"Promedio de Matemáticas: {promedioMatematicas}");
            Console.WriteLine($"Promedio de Física: {promedioFisica}");
            Console.WriteLine($"Promedio de Inglés: {promedioIngles}");
            Console.WriteLine($"Promedio de Sociales: {promedioSociales}");








        }
    }
}
