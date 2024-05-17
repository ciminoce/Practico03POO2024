namespace ConsoleApp03.Entidades
{
    public class Peso
    {
        private static double cotizacionRespectoDolar;
        private double cantidad;

        public static double GetCotizacionRespectoDolar()
            => cotizacionRespectoDolar;
        public double GetCantidad() => cantidad;

        static Peso()
        {
            cotizacionRespectoDolar =1000.45;
        }
        public Peso(double Cantidad, double Cotizacion) : this(Cantidad)
        {

            cotizacionRespectoDolar = Cotizacion;
        }
        public Peso(double Cantidad)
        {
            cantidad = Cantidad;
        }
        public static implicit operator double(Peso peso)
        {
            return peso.GetCantidad();
        }
        public static implicit operator Peso(double cantidad)
        {
            return new Peso(cantidad);
        }
        public static implicit operator Dolar(Peso peso)
        {
            return new Dolar(peso.GetCantidad() / Peso
                .GetCotizacionRespectoDolar());
        }
        public static implicit operator Euro(Peso peso)
        {
            return (Euro) (Dolar)peso;
        }
        public static bool operator ==(Peso p1, Peso p3)
        {
            if (p1 is null || p3 is null)
            {
                return false;
            }
            return p1.GetCantidad() ==p3.GetCantidad();
        }
        public static bool operator !=(Peso p1, Peso p3)
        {
            return !(p1==p3);
        }

        public static bool operator ==(Peso p, Dolar d)
        {
            if (d is null || p is null)
            {
                return false;
            }
            return p == (Peso)d;
        }
        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p==d);
        }

        public static bool operator ==(Peso p, Euro e)
        {
            if (p is null || e is null)
            {
                return false;
            }
            return p == (Peso)(Dolar)e;
        }

        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }
        public static Peso operator +(Peso d1, Peso d2)
        {
            return new Peso(d1.cantidad + d2.cantidad);
        }
        public static Peso operator -(Peso d1, Peso d2)
        {
            return new Peso(d1.cantidad - d2.cantidad);
        }
        public static Peso operator +(Peso d1, Dolar d2)
        {
            return new Peso(d1.cantidad + ((Peso)d2).cantidad);
        }
        public static Peso operator -(Peso d1, Dolar d2)
        {
            return new Peso(d1.cantidad - ((Peso)d2).cantidad);
        }
        public static Peso operator +(Peso d1, Euro d2)
        {
            return new Peso(d1.cantidad + ((Peso)d2).cantidad);
        }
        public static Peso operator -(Peso d1, Euro d2)
        {
            return new Peso(d1.cantidad - ((Peso)d2).cantidad);
        }

        public string GetCotizacion(double cotizacion, string abreviatura)
        {
            var conversion = GetCantidad() * cotizacion;
            return $"{GetCantidad()} en ARS equivalen a {conversion} {abreviatura}";
        }
        public override bool Equals(object? obj)
        {
            if (obj is null || !(obj is Peso)) return false;
            return this.cantidad == ((Peso)obj).cantidad;
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
