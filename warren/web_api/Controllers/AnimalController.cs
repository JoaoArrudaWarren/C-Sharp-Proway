using Data.Model;
using Data.Repository;

namespace web_api.Controllers
{
    public class AnimalController : GenericController<Animal, AnimalRepository>
    {
        public AnimalController() : base(new AnimalRepository())
        {
        }
    }
}
