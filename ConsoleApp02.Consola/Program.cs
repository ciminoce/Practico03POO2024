using ConsoleApp02.Entidades;

namespace ConsoleApp02.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de uso en un programa de consola
            Fraccion fraccion1 = new Fraccion(3, 4);
            Fraccion fraccion2 = new Fraccion(1, 2);

            // Mostrar fracciones
            Console.WriteLine("Fracción 1:");
            fraccion1.MostrarFraccion();
            Console.WriteLine("Fracción 2:");
            fraccion2.MostrarFraccion();

            // Operaciones aritméticas entre fracciones
            Fraccion suma = fraccion1 + fraccion2;
            Console.WriteLine("Suma de fracciones:");
            suma.MostrarFraccion();

            Fraccion resta = fraccion1 - fraccion2;
            Console.WriteLine("Resta de fracciones:");
            resta.MostrarFraccion();

            Fraccion multiplicacion = fraccion1 * fraccion2;
            Console.WriteLine("Multiplicación de fracciones:");
            multiplicacion.MostrarFraccion();

            Fraccion division = fraccion1 / fraccion2;
            Console.WriteLine("División de fracciones:");
            division.MostrarFraccion();

            // Operaciones aritméticas entre fracción y entero
            Fraccion fraccionEntero = fraccion1 + 2;
            Console.WriteLine("Suma de fracción y entero:");
            fraccionEntero.MostrarFraccion();

            // Validación de igualdad
            Console.WriteLine($"¿Las fracciones son iguales?: {fraccion1 == fraccion2}");

            // Conversión implícita de entero a fracción
            Fraccion fraccionEntero2 = 5;
            Console.WriteLine("Conversión implícita de entero a fracción:");
            fraccionEntero2.MostrarFraccion();

            // Conversión explícita de fracción a string
            string fraccionString = (string)fraccion1;
            Console.WriteLine("Conversión explícita de fracción a string:");
            Console.WriteLine(fraccionString);

            // Conversión explícita de string a fracción
            Fraccion fraccionDesdeString = (Fraccion)"2/3";
            Console.WriteLine("Conversión explícita de string a fracción:");
            fraccionDesdeString.MostrarFraccion();
        }
    }
}
