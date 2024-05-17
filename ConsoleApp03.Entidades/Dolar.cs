namespace ConsoleApp03.Entidades
{
    public class Dolar
    {
        private static double cotizacionRespectoDolar;
        private double cantidad;

        public static double GetCotizacionRespectoDolar()
            => cotizacionRespectoDolar;
        public double GetCantidad() => cantidad;

        static Dolar()
        {
            cotizacionRespectoDolar = 1;
        }
        public Dolar(double Cantidad, double Cotizacion) : this(Cantidad)
        {

            cotizacionRespectoDolar = Cotizacion;
        }
        public Dolar(double Cantidad)
        {
            cantidad = Cantidad;
        }

        public static implicit operator double(Dolar dolar)
        {
            return dolar.GetCantidad();
        }
        public static implicit operator Dolar(double cantidad)
        {
            return new Dolar(cantidad);
        }
        public static implicit operator Peso(Dolar dolar)
        {
            return new Peso(dolar.GetCantidad() *
                Peso.GetCotizacionRespectoDolar());
        }
        public static implicit operator Euro(Dolar dolar)
        {
            return new
                Euro(dolar.GetCantidad() * Euro.GetCotizacionRespectoDolar());
        }
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            if (d1 is null || d2 is null)
            {
                return false;
            }
            return d1.GetCantidad() == d2.GetCantidad();
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        public static bool operator ==(Dolar d, Peso p)
        {
            if (d is null || p is null)
            {
                return false;
            }
            return d == (Dolar)p;
        }
        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            if (d is null || e is null)
            {
                return false;
            }
            return d == (Dolar)e;
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }
        public static Dolar operator +(Dolar d1, Dolar d2)
        {
            return new Dolar(d1.cantidad + d2.cantidad);
        }
        public static Dolar operator -(Dolar d1, Dolar d2)
        {
            return new Dolar(d1.cantidad - d2.cantidad);
        }
        public static Dolar operator +(Dolar d1, Peso d2)
        {
            return new Dolar(d1.cantidad + ((Dolar)d2).cantidad);
        }
        public static Dolar operator -(Dolar d1, Peso d2)
        {
            return new Dolar(d1.cantidad - ((Dolar)d2).cantidad);
        }

        public string GetCotizacion(double cotizacion, string abreviatura)
        {
            var conversion = GetCantidad() * cotizacion;
            return $"{GetCantidad()} en USD equivalen a {conversion} {abreviatura}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is null || !(obj is Dolar)) return false;
            return this.cantidad==((Dolar)obj).cantidad;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                return hash += 23 * cantidad.GetHashCode();
            }
        }
    }
}
