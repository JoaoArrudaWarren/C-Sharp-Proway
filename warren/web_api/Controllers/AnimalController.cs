using Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            Animal animal = new Animal { Nome = "opa", Especie = "Felis", Id = 1, Peso = 2.5f };
            return animal.Nome;
        }

    }
}
