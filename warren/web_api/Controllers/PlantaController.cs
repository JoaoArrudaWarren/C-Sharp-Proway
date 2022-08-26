using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantaController : ControllerBase
    {
        public PlantaController()
        {
            repo = new();
        }

        PlantaRepository repo;

        [HttpGet("{id}")]
        public Planta Get(int id)
        {
            return repo.GetById(id);
        }

        [HttpGet]
        public List<Planta> GetAll()
        {
            return repo.GetAll();
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return repo.Delete(id);
        }

        [HttpPost]
        public string Create(Planta model)
        {
            return repo.Create(model);
        }
    }
}