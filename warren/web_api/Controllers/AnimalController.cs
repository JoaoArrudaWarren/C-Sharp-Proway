using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        public AnimalController()
        {
            repo = new();
        }

        AnimalRepository repo;

        [HttpGet("{id}")]
        public Animal Get(int id)
        {
            return repo.GetById(id);
        }

        [HttpGet]
        public List<Animal> GetAll()
        {
            return repo.GetAll();
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return repo.Delete(id);
        }

        [HttpPost]
        public string Create(Animal model)
        {
            return repo.Create(model);
        }

        [HttpPatch]
        public string Update(Animal model)
        {
            return repo.Update(model);
        }

        [HttpPut]
        public string Modify(Animal model)
        {
            return repo.Modify(model);
        }
    }
}
