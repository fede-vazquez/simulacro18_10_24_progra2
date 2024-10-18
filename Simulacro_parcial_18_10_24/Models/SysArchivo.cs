using System.Security.Cryptography.X509Certificates;
using TiendaVideojuegos.Enums;

namespace TiendaVideojuegos.Models
{
    public static class SysArchivo
    {
        private static string nombreArchivo = "../../../videojugos.txt";

        public static void GuardarVideojuego(VideoJuego videojuego)
        {
            using StreamWriter writer = new StreamWriter(nombreArchivo, true);
            writer.WriteLine(videojuego);
        }

        public static void GuardarDatos(List<VideoJuego> videojuegos)
        {
            if (videojuegos.Count == 0) return;

            using StreamWriter writer = new StreamWriter(nombreArchivo);
            foreach (var v in videojuegos)
            {
                writer.WriteLine(v);
            }
        }

        public static List<VideoJuego> CargarVideojuegos()
        {
            List<VideoJuego> videoJuegos = new List<VideoJuego>();
            if(!File.Exists(nombreArchivo)) return videoJuegos;

            foreach (var linea in File.ReadAllLines(nombreArchivo))
            {
                string[] p = linea.Split(", ");

                string nombre = p[0];
                double precio = double.Parse(p[1]);
                int cantidadStock = int.Parse(p[2]);
                Plataforma plataforma = (Plataforma)Enum.Parse(typeof(Plataforma), p[3]);

                VideoJuego v = new VideoJuego(nombre, precio, cantidadStock, plataforma);
                videoJuegos.Add(v);
            }

            return videoJuegos;
        }
    }
}
