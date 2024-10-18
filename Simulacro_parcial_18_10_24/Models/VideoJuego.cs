using TiendaVideojuegos.Enums;

namespace TiendaVideojuegos.Models
{
    public class VideoJuego
    {
        public string Nombre { get; private set; }
        public double Precio { get; private set; }
        public int CantidadEnStock { get; private set; }
        public Plataforma Plataforma { get; private set; }

        public VideoJuego(string nombre, double precio, int cantidadEnStock, Plataforma plataforma)
        {
            Nombre = nombre;
            Precio = precio;
            CantidadEnStock = cantidadEnStock;
            Plataforma = plataforma;
        }

        private void ActualizarVideojuego(int nuevoPrecio, int nuevaCantidad)
        {
            Precio = nuevoPrecio;
            CantidadEnStock = nuevaCantidad;
        }

        public override string ToString()
        {
            return $"{Nombre}, {Precio}, {CantidadEnStock}, {Plataforma}";
        }
    }
}
