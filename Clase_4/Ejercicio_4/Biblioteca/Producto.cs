using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigoDeBarra, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigoDeBarra;
            this.precio = precio;
        }
        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }
     

        public static explicit operator string(Producto producto)
        {
            return producto.codigoDeBarra;
        }
        public static bool operator ==(Producto producto1, Producto producto2)
        {
            if (!(producto1 is null) || (producto2 is null))
            {
                return producto1.marca == producto2.marca && producto1.codigoDeBarra == producto2.codigoDeBarra;
            }
            return false;
            
        }

        public static bool operator !=(Producto producto1, Producto producto2)
        {
            return !(producto1.marca == producto2.marca && producto1.codigoDeBarra == producto2.codigoDeBarra);
        }

        public static bool operator ==(Producto producto, string marca)
        {
 
            return producto.marca == marca;
        }
        public static bool operator !=(Producto producto, string marca)
        {
            return !(producto.marca == marca);
        }

        public static string MostrarProducto(Producto producto)
        {

            return String.Format($"marca {producto.marca} codigo {producto.codigoDeBarra} precio {producto.precio} ");
        }
    }
}
