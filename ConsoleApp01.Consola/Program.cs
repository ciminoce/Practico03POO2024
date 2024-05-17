using ConsoleApp01.Entidades;

namespace ConsoleApp01.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de uso en un programa de consola
            Sumador sumador = new Sumador(5);
            Console.WriteLine("Cantidad de sumas inicial: " + sumador.ObtenerCantidadSumas());

            // Suma dos números enteros
            int resultadoSumaEnteros = sumador.Sumar(3, 4);
            Console.WriteLine("Resultado de la suma de enteros: " + resultadoSumaEnteros);
            Console.WriteLine("Cantidad de sumas después de sumar enteros: " + sumador.ObtenerCantidadSumas());

            // Concatena dos strings
            string resultadoConcatenacion = sumador.Sumar("Hola ", "Mundo");
            Console.WriteLine("Resultado de la concatenación: " + resultadoConcatenacion);
            Console.WriteLine("Cantidad de sumas después de concatenar strings: " + sumador.ObtenerCantidadSumas());

            // Comprobación de igualdad
            Sumador otroSumador = new Sumador(6);
            Console.WriteLine("¿Son iguales los sumadores?: " + sumador.Equals(otroSumador));

            // Conversión explícita
            int cantidadSumas = (int)sumador;
            Console.WriteLine("Cantidad de sumas: " + cantidadSumas);

        }
    }
}
