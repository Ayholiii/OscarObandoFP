namespace ParcialCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Un profesor tiene las calificaciones de 14 alumnos y necesita procesar la información para obtener un análisis general del curso. Las notas se encuentran en un rango de 0 a 10.
              El programa debe realizar las siguientes operaciones:
              Leer por teclado la nota de cada uno de los 14 estudiantes.
              Calcular el promedio de todas las notas.
              Identificar y mostrar cuál fue la nota mayor y la nota menor entre las ingresadas.
              Contar cuántos estudiantes aprobaron la asignatura (nota mayor o igual a 6.0).
                Mostrar por pantalla:
                - El promedio general.
                - La nota más alta.
                - La nota más baja.
                - La cantidad de aprobados en el curso. */

            int cantidadAlumnos = 14;
            double sumaNotas = 0;
            double notaMayor = 0;
            double notamenor = 0;
            int cantidadAprobados = 0;
            double nota = 0;
            double promedio = 0;


            for (int i = 1; i <= cantidadAlumnos; i++)
            {
                Console.WriteLine($"Ingrese la nota del alumno {i} (entre 0 y 10):");
                nota = double.Parse(Console.ReadLine());
                if (nota == 0)
                {
                    notamenor = nota;
                }

                if (notamenor == 0)
                {
                    notamenor = nota;
                }
             
                if (nota > notaMayor)
                {
                    notaMayor = nota;
                }

                if (nota < notamenor)
                {
                    notamenor = nota;
                }
               
                if (nota >= 6.0)
                {
                    cantidadAprobados++;
                }

                sumaNotas += nota;
                promedio = sumaNotas / i;
            }
            Console.WriteLine($"El promedio general es: {promedio}");
            Console.WriteLine($"La nota más alta es: {notaMayor}");
            Console.WriteLine($"La nota más baja es: {notamenor}");
            Console.WriteLine($"La cantidad de aprobados en el curso es: {cantidadAprobados}");

        }

    }
}