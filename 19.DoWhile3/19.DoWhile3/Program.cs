namespace _19.DoWhile3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //En un grupo de 100 alumnos, se desea saber cuántos de los estudiantes son hombres y cuántos son mujeres, además se desea saber cuántos son mayores de edad y cuántos no.  

            string genero = "";
            int edad = 0;
            int hombre = 0;
            int mujer = 0; 
            int mayores = 0;
            int menores = 0;
            int total = 0;

            do
            {
                total++;

                Console.WriteLine("Ingrese Su Edad:");
                edad = int.Parse(Console.ReadLine());

                if (edad >= 18)
                {
                    mayores++;
                }
                else
                {
                    menores++;
                }

                Console.WriteLine("Indique Su Genero: M para Masculino y F para Femenino");
                genero = Console.ReadLine().ToLower();

                if (genero == "M")
                {
                    hombre++;
                }
                if (genero == "F")
                {
                    mujer++;
                }

            } while (total < 100);
            
            Console.WriteLine($"Hombres: {hombre}");
            Console.WriteLine($"Mujeres: {mujer}");
            Console.WriteLine($"Mayores de 18: {mayores}");
            Console.WriteLine($"menores de 18: {menores}");

        }
    }
}
