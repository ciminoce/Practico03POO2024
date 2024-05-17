namespace ConsoleApp04.Entidades
{
    public class Producto
    {
        private string codigoDeBarras;
        private string marca;
        private float precio;

        public Producto(string codigoDeBarras, string marca, float precio)
        {
            this.codigoDeBarras = codigoDeBarras;
            this.marca = marca;
            this.precio = precio;
        }
        public string GetMarca() => marca;
        public float GetPrecio() => precio;

        public static string MostrarProducto(Producto? producto)
        {
            if (producto is not null)
            {
                return $"Cod. Barra:{producto.codigoDeBarras} -" +
            $" Marca:{producto.GetMarca()} - " +
            $"Precio:{producto.GetPrecio()}";

            }
            return string.Empty;
        }

        public static explicit operator string(Producto producto)
        {
            return producto.codigoDeBarras;
        }
        public static bool operator ==(Producto p1, Producto p3)
        {
            if (p1 is null || p3 is null)
            {
                return false;
            }
            return p1.codigoDeBarras == p3.codigoDeBarras &&
                p1.GetMarca() == p3.GetMarca();
        }
        public static bool operator !=(Producto p1, Producto p3)
        {
            return !(p1 == p3);
        }
        public static bool operator==(Producto p, string marca)
        {
            return p.GetMarca() == marca;
        }
        public static bool operator!=(Producto p, string marca)
        {
            return !(p == marca);
        }
    }
}
