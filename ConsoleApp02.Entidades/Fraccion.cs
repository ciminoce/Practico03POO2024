namespace ConsoleApp02.Entidades
{
    public class Fraccion
    {
        private int numerador;
        private int denominador;

        // Constructor que recibe numerador y denominador
        public Fraccion(int numerador, int denominador)
        {
            if (denominador == 0)
                throw new ArgumentException("El denominador no puede ser cero.");

            this.numerador = numerador;
            this.denominador = denominador;
        }

        // Constructor que recibe solamente
        // el numerador (denominador por defecto: 1)
        public Fraccion(int numerador) : this(numerador, 1)
        {
        }

        // Método para mostrar la fracción
        public string MostrarFraccion()
        {
            return ($"{numerador}/{denominador}");
        }

        // Método validador
        public static bool ValidarFraccion(int numerador, int denominador)
        {
            return denominador != 0;
        }

        // Sobrescritura del operador de igualdad (==)
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Fraccion f))
                return false;

            return this.numerador * f.denominador == f.numerador * this.denominador;
        }
        // Método GetHashCode
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + numerador.GetHashCode();
                hash = hash * 23 + denominador.GetHashCode();
                return hash;
            }
        }
        // Conversión implícita de un número entero a Fraccion
        public static implicit operator Fraccion(int numero)
        {
            return new Fraccion(numero);
        }

        // Conversión explícita de Fraccion a string
        public static explicit operator string(Fraccion fraccion)
        {
            return $"{fraccion.numerador}/{fraccion.denominador}";
        }

        // Conversión explícita de string a Fraccion
        public static explicit operator Fraccion(string fraccionString)
        {
            string[] partes = fraccionString.Split('/');
            if (partes.Length != 2 || !int.TryParse(partes[0], out int numerador)
                || !int.TryParse(partes[1], out int denominador))
                throw new FormatException("Formato de fracción inválido.");

            return new Fraccion(numerador, denominador);
        }

        // Sobrescritura de operadores aritméticos para operaciones entre fracciones

        public static bool operator ==(Fraccion f1, Fraccion f2)
        {
            if (ReferenceEquals(f1, f2))
                return true;

            if (f1 is null || f2 is null)
                return false;

            return f1.Equals(f2);
        }
        public static bool operator !=(Fraccion f1, Fraccion f2)
        {
            return !(f1 == f2); // Reutilización de código
        }

        public static Fraccion operator +(Fraccion f1, Fraccion f2)
        {
            int nuevoDenominador = f1.denominador * f2.denominador;
            int nuevoNumerador = f1.numerador * f2.denominador +
                f2.numerador * f1.denominador;
            return new Fraccion(nuevoNumerador, nuevoDenominador);
        }

        public static Fraccion operator -(Fraccion f1, Fraccion f2)
        {
            int nuevoDenominador = f1.denominador * f2.denominador;
            int nuevoNumerador = f1.numerador * f2.denominador -
                f2.numerador * f1.denominador;
            return new Fraccion(nuevoNumerador, nuevoDenominador);
        }

        public static Fraccion operator *(Fraccion f1, Fraccion f2)
        {
            return new Fraccion(f1.numerador * f2.numerador,
                f1.denominador * f2.denominador);
        }

        public static Fraccion operator /(Fraccion f1, Fraccion f2)
        {
            if (f2.numerador == 0)
                throw new DivideByZeroException("No se puede dividir por cero.");

            return new Fraccion(f1.numerador * f2.denominador,
                f1.denominador * f2.numerador);
        }

        // Sobrescritura de operadores aritméticos para operaciones entre fracción y entero
        public static Fraccion operator +(Fraccion f, int numero)
        {
            return f + new Fraccion(numero);
        }

        public static Fraccion operator -(Fraccion f, int numero)
        {
            return f - new Fraccion(numero);
        }

        public static Fraccion operator *(Fraccion f, int numero)
        {
            return f * new Fraccion(numero);
        }

        public static Fraccion operator /(Fraccion f, int numero)
        {
            if (numero == 0)
                throw new DivideByZeroException("No se puede dividir por cero.");

            return new Fraccion(f.numerador, f.denominador * numero);
        }
        //Agregados
        // Método para simplificar la fracción a su forma más reducida
        public void SimplificarFraccion()
        {
            int gcd = CalcularMCD(numerador, denominador);
            numerador /= gcd;
            denominador /= gcd;
        }

        // Método para calcular el máximo común divisor (MCD)
        // utilizando el algoritmo de Euclides
        // Código proporcionado por la IA
        private int CalcularMCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return Math.Abs(a);
        }

        // Método para calcular y devolver el valor decimal equivalente de la fracción
        public double CalcularValorDecimal()
        {
            return (double)numerador / denominador;
        }
        // Constructor para crear una fracción mixta
        public Fraccion(int parteEntera, int nuevoNumerador, int denominador)
        {
            this.numerador = parteEntera * denominador + nuevoNumerador;
            this.denominador = denominador;
        }
        // Método para mostrar la fracción mixta como cadena de caracteres
        public string MostrarFraccionMixta()
        {
            if (Math.Abs(numerador) >= denominador)
            {
                int parteEntera = numerador / denominador; // Parte entera de la fracción mixta
                int nuevoNumerador = Math.Abs(numerador % denominador); // Nuevo numerador de la fracción mixta
                string signo = numerador < 0 ? "-" : ""; // Determinar el signo de la fracción mixta

                return $"{signo}{parteEntera} {nuevoNumerador}/{denominador}";
            }
            else
            {
                // La fracción es propia, mostrarla en su forma estándar
                return MostrarFraccion();
            }
        }
    }
}
