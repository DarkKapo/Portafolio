using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<ProyectoDTO> ObtenerProyectos();
    }
    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<ProyectoDTO> ObtenerProyectos()
        {
            return new List<ProyectoDTO> {
                new ProyectoDTO
                {
                    Titulo = "Amazon",
                    Descripcion = "E-commerce con ASP>NET Core",
                    ImagenURL = "/imagenes/amazon.png",
                    Link = "https://amazon.com"
                },
                new ProyectoDTO
                {
                    Titulo = "New York Times",
                    Descripcion = "Página de noticias en React",
                    ImagenURL = "/imagenes/nyt.png",
                    Link = "https://nytimes.com"
                },
                new ProyectoDTO
                {
                    Titulo = "Reddit",
                    Descripcion = "Red social para compartir en comunidad",
                    ImagenURL = "/imagenes/reddit.png",
                    Link = "https://reddit.com"
                },
                new ProyectoDTO
                {
                    Titulo = "Steam",
                    Descripcion = "Tienda en línea para comprar video juegos",
                    ImagenURL = "/imagenes/steam.png",
                    Link = "https://store.steampower.com"
                }
            };
        }
    }
}
