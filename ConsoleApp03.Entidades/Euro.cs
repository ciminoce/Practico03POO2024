namespace ConsoleApp03.Entidades
{
    public class Euro
    {
        private static double cotizacionRespectoDolar;
        private double cantidad;

        public static double GetCotizacionRespectoDolar()
            => cotizacionRespectoDolar;
        public double GetCantidad() => cantidad;

        static Euro()
        {
            cotizacionRespectoDolar = 1.08;
        }
        public Euro(double Cantidad, double Cotizacion) : this(Cantidad)
        {

            cotizacionRespectoDolar = Cotizacion;
        }
        public Euro(double Cantidad)
        {
            cantidad = Cantidad;
        }
        public static implicit operator double(Euro euro)
        {
            return euro.GetCantidad();
        }
        public static implicit operator Euro(double cantidad)
        {
            return new Euro(cantidad);
        }
        public static implicit operator Dolar(Euro euro)
        {
            return new 
                Dolar(euro.GetCantidad()/Euro
                .GetCotizacionRespectoDolar());
        }
        public static implicit operator Peso(Euro euro)
        {
            return (Peso)(Dolar)euro;
        }
        public static bool operator ==(Euro e1, Euro e2)
        {
            if (e1 is null || e2 is null)
            {
                return false;
            }
            return e1.GetCantidad() == e2.GetCantidad();
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1==e2);
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            if (e is null ||d is null)
            {
                return false;
            }
            return e == (Euro)d;
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e==d);
        }

        public static bool operator ==(Euro e, Peso p)
        {
            if (p is null || e is null)
            {
                return false;
            }
            return e == (Euro)(Dolar)p;
        }

        public static bool operator !=(Euro e, Peso p)
        {
            return !(p == e);
        }
        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad() + ((Euro)d).GetCantidad());
        }
        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad() - ((Euro)d).GetCantidad());
        }
        public static Euro operator +(Euro e, Peso d)
        {
            return new Euro(e.GetCantidad() + ((Euro)d).GetCantidad());
        }
        public static Euro operator -(Euro e, Peso d)
        {
            return new Euro(e.GetCantidad() - ((Euro)d).GetCantidad());
        }
        public override bool Equals(object? obj)
        {
            if (obj is null || !(obj is Euro)) return false;
            return this.cantidad == ((Euro)obj).cantidad;
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
