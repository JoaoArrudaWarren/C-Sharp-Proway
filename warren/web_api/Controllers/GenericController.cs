using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class GenericController<T, R> : ControllerBase where T : BaseModel where R : BaseRepository<T>
    {
        private R repo;

        public GenericController(R repo)
        {
            this.repo = repo;
        }

        [HttpGet("{id}")]
        public T Get(int id)
        {
            return repo.GetById(id);
        }

        [HttpGet]
        public List<T> GetAll()
        {
            return repo.GetAll();
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return repo.Delete(id);
        }

        [HttpPost]
        public string Create(T model)
        {
            return repo.Create(model);
        }

        [HttpPatch]
        public string Update(T model)
        {
            return repo.Update(model);
        }

        [HttpPut]
        public string Modify(T model)
        {
            return repo.Modify(model);
        }
    }
}
