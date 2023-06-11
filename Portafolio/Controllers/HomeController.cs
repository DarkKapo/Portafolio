using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Obtenermos los 3 para mostrar en el index
            //Tendremos otra vista donde se muestran todos
            var proyectos = ObtenerProyectos().Take(3).ToList();
            //Al modelo le pasamos los datos de los proyectos
            var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
            return View( modelo );
        }

        private List<ProyectoDTO> ObtenerProyectos()
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}