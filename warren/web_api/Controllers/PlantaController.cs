using Data.Model;
using Data.Repository;

namespace web_api.Controllers
{
    public class PlantaController : GenericController<Planta, PlantaRepository>
    {
        public PlantaController() : base(new PlantaRepository())
        {
        }
    }
}