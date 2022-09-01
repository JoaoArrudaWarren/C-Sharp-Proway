using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;
using web_api.DTO;

namespace web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcessController : ControllerBase
    {
        [HttpPost("Logon")]
        public Usuario Logon(UsuarioDto usuarioDto)
        {
            UsuarioRepository repo = new();
            return repo.Logon(usuarioDto.Email, usuarioDto.Password);
        }
    }
}
