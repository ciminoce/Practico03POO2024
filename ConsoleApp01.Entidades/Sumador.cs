namespace ConsoleApp01.Entidades
{
    public class Sumador
    {
        private int cantidadSumas;

        // Constructor que recibe un entero para inicializar cantidadSumas
        public Sumador(int cantidadInicial)
        {
            this.cantidadSumas = cantidadInicial;
        }

        // Constructor sin parámetros que inicializa cantidadSumas a 0
        public Sumador()
        {
            this.cantidadSumas = 0;
        }

        // Método para obtener la cantidad de sumas realizadas
        public int ObtenerCantidadSumas()
        {
            return cantidadSumas;
        }

        // Método sobrecargado para sumar dos números enteros
        public int Sumar(int a, int b)
        {
            cantidadSumas++;
            return a + b;
        }

        // Método sobrecargado para concatenar dos strings
        public string Sumar(string a, string b)
        {
            cantidadSumas++;
            return a + b;
        }

        // Sobrescritura del operador de igualdad (==)
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Sumador s)) return false;
            return this.cantidadSumas == s.cantidadSumas;
        }

        // Método GetHashCode
        public override int GetHashCode()
        {
            return cantidadSumas.GetHashCode();
        }

        // Conversión explícita que retorna cantidadSumas
        public static explicit operator int(Sumador sumador)
        {
            return sumador.cantidadSumas;
        }
    }
}
