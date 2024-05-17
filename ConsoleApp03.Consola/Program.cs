using ConsoleApp03.Entidades;

namespace ConsoleApp03.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prueba de funcionalidades

            // Crear Dolar
            Dolar d1 = new Dolar(100);
            Console.WriteLine("Cantidad de Dolar d1: " + d1.GetCantidad());

            // Crear Pesos
            Peso p1 = new Peso(5000);
            Console.WriteLine("Cantidad de Pesos p1: " + p1.GetCantidad());

            // Conversión implícita de double a Dolar
            Dolar d2 = 50d;
            Console.WriteLine("Cantidad de Dolar d2: " + d2.GetCantidad());

            // Conversión explícita de Dolar a double
            double cantidadDolar = (double)d2;
            Console.WriteLine("Cantidad de Dolar d2 en double: " + cantidadDolar);

            // Comparación entre Dolar y Pesos
            Console.WriteLine("¿d1 es igual a p1?: " + (d1 == p1)); // Comparación de cantidad

            // Operaciones aritméticas entre Dolar y Pesos
            Dolar sumaDolarPesos = d1 + p1;
            Console.WriteLine("Suma de d1 y p1: " + sumaDolarPesos.GetCantidad());

            Dolar restaDolarPesos = d1 - p1;
            Console.WriteLine("Resta de d1 y p1: " + restaDolarPesos.GetCantidad());

            // Crear Euro
            Euro e1 = new Euro(80);
            Console.WriteLine("Cantidad de Euro e1: " + e1.GetCantidad());

            // Conversión implícita de double a Euro
            Euro e2 = 100;
            Console.WriteLine("Cantidad de Euro e2: " + e2.GetCantidad());

            // Conversión explícita de Euro a double
            double cantidadEuro = (double)e2;
            Console.WriteLine("Cantidad de Euro e2 en double: " + cantidadEuro);

            // Comparación entre Euro y Dolar
            Console.WriteLine("¿e1 es igual a d1?: " + (e1 == d1)); // Comparación de cantidad

            // Operaciones aritméticas entre Euro y Dolar
            Euro sumaEuroDolar = e1 + d1;
            Console.WriteLine("Suma de e1 y d1: " + sumaEuroDolar.GetCantidad());

            Euro restaEuroDolar = e1 - d1;
            Console.WriteLine("Resta de e1 y d1: " + restaEuroDolar.GetCantidad());
        }
    }
}
