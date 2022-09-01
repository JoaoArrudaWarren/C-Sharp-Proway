using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class GenericController<T, R> : ControllerBase where T : BaseModel where R : BaseRepository<T>
    {
        private R repo = Activator.CreateInstance<R>();

        [HttpGet("GetByID/{id}")]
        public T Get(int id)
        {
            return repo.GetById(id);
        }

        [HttpGet("GetAll")]
        public List<T> GetAll()
        {
            return repo.GetAll();
        }

        [HttpDelete("DeleteByID/{id}")]
        public string Delete(int id)
        {
            return repo.Delete(id);
        }

        [HttpPost("Create")]
        public string Create(T model)
        {
            return repo.Create(model);
        }

        [HttpPatch("UpdateOneParam")]
        public string Update(T model)
        {
            return repo.Update(model);
        }

        [HttpPut("Recreate")]
        public string Modify(T model)
        {
            return repo.Modify(model);
        }
    }
}
