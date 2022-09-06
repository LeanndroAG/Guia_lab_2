using System;
using System.Text;

namespace Biblioteca
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacion;

        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion) 
            : this(capacidad)
        {
            this.ubicacion = ubicacion;
        }
        public Producto[] GetProductos()
        {
            return this.productos;
        }
      
        //sobrecarga 
        public static bool operator ==(Estante estante, Producto producto)
        {
            for (int i = 0; i < estante.productos.Length; i++)
            {
                if (estante.productos[i] == producto)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Estante estante, Producto producto)
        {
            return !(estante == producto);
        }
        public static bool operator +(Estante estante, Producto producto)
        {
            if (estante != producto)
            {
                for (int i = 0; i < estante.productos.Length; i++)
                {
                    if (estante.productos[i] is null)
                    {
                        estante.productos[i] = producto;
                        return true;
                    }
                }
            }
            return false;
        }
        public static Estante operator -(Estante estante, Producto producto)
        {
            for (int i = 0; i < estante.productos.Length; i++)
            {
                if (estante.productos[i] == producto)
                {
                    estante.productos[i] = null;
                    break;
                }
            }
            return estante;
        }

        public static string MostrarEstante(Estante estante)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ubicacion: {estante.ubicacion} \n");

            for (int i = 0; i < estante.productos.Length; i++)
            {
                if (!(estante.productos[i] is null))
                {
                    sb.AppendLine(Producto.MostrarProducto(estante.productos[i]));
                }
            }
            return sb.ToString();
        }
    }
}
