using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Servicios;
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
            var repositorioProyectos = new RepositorioProyectos();
            //Obtenemos los 3 para mostrar en el index
            //Tendremos otra vista donde se muestran todos
            var proyectos = repositorioProyectos.ObtenerProyectos().Take(3).ToList();
            //Al modelo le pasamos los datos de los proyectos
            var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
            return View( modelo );
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