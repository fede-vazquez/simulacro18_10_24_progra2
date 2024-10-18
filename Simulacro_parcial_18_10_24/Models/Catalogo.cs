namespace TiendaVideojuegos.Models
{
    public static class Catalogo
    {
        public static List<VideoJuego> VideoJuegos = new List<VideoJuego>();

        public static void AgregarVideoJuego(VideoJuego videoJuego)
        {
            VideoJuegos.Add(videoJuego);
            SysArchivo.GuardarVideojuego(videoJuego);
        }

        public static void MostrarVideojuegos()
        {
            if(VideoJuegos.Count == 0)
            {
                Console.WriteLine("\nNo hay videojuegos para mostrar");
            }
            else
            {
                Console.WriteLine("\nVideojuegos en el catálogo: ");
                foreach (var v in VideoJuegos)
                {
                    Console.WriteLine(v);
                }
            }
        }

        public static void EliminarVideojuego(string nombreVideojuego)
        {
            VideoJuego videojuego = VideoJuegos.Find(v => v.Nombre == nombreVideojuego);

            VideoJuegos.Remove(videojuego);
            GuardarVideojuegos();
        }

        public static void ModificarVideojuego(string nombre, VideoJuego nuevoVideojuego)
        {
            EliminarVideojuego(nombre);
            AgregarVideoJuego(nuevoVideojuego);
            Console.WriteLine($"Videojuego '{nombre}' modificado.");
        }

        public static void GuardarVideojuegos() => SysArchivo.GuardarDatos(VideoJuegos);

        public static void CargarVideojugos() => VideoJuegos = SysArchivo.CargarVideojuegos();
    }
}