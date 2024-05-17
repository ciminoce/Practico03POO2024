using ConsoleApp04.Entidades;
using System.Text;

namespace ConsoleApp04.Datos
{
    public class Estanteria
    {
        private Producto[]? productos;
        private int ubicacionEstante;

        private Estanteria(int capacidad)
        {
            productos = new Producto[capacidad];
            ubicacionEstante = -1;
        }
        public Estanteria(int capacidad, int ubicacionEstante):this(capacidad)
        {
            
        }

        public Producto[]? GetProductos() => productos;

        public bool EstaVacia() => ubicacionEstante ==-1;
        public bool EstaCompleta()=>ubicacionEstante==productos.Length-1;
        public static string MostrarEstantes(Estanteria e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Contenido de la Estantería");
            if (!e.EstaVacia())
            {
                foreach (Producto productoEnEstanteria in e.GetProductos())
                {
                    if (productoEnEstanteria is not null)
                    {
                        sb.AppendLine(Producto
                            .MostrarProducto(productoEnEstanteria));
                    }
                }
            }
            else
            {
                sb.AppendLine("La estantería está vacía");
            }
            return sb.ToString();
        }

        public static bool operator ==(Estanteria e, Producto p)
        {
            if (e is null || p is null)
            {
                return false;
            }
            foreach (Producto pEnEstanteria in e.GetProductos())
            {
                if (pEnEstanteria==p)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Estanteria e, Producto p)
        {
            return !(e == p);
        }
        public static bool operator +(Estanteria e, Producto p)
        {
            if (e is null || p is null)
            {
                return false;
            }
            if (e.EstaCompleta())
            {
                return false;
            }
            if (e == p)
            {
                return false;
            }
            for (int i = 0; i < e.GetProductos().Length; i++)
            {
                if (e.productos[i] is null)
                {
                    e.productos[i] = p;
                    e.ubicacionEstante = i;
                    return true;
                }
            }
            return false;
        }

        public static Estanteria operator -(Estanteria e, Producto p)
        {
            if (e is null || p is null)
            {
                return e;
            }
            if (e.EstaVacia())
            {
                return e;
            }
            if (e != p)
            {
                return e;
            }
            for (int i = 0; i < e.GetProductos().Length; i++)
            {
                if (e.productos[i] is not null && e.productos[i]==p)
                {
                    e.productos[i] = null;
                    e.ubicacionEstante-- ;
                    return e;
                }
            }
            return e;


        }

        public Producto? GetProducto(int index)
        {
            if (index<0 || index>productos?.Length-1)
            {
                return null;
            }
            return productos[index];
        }
    }
}
