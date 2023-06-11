//encapsula la información para cargar la vista index
namespace Portafolio.Models
{
    public class HomeIndexViewModel
    {
        //Se guarda una enumeración de proyectos
        public IEnumerable<ProyectoDTO> Proyectos { get; set; }
    }
}
