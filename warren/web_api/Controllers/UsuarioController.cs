using Data.Model;
using Data.Repository;

namespace web_api.Controllers
{
    public class UsuarioController : GenericController<Usuario, UsuarioRepository>
    {
        public UsuarioController() : base(new UsuarioRepository())
        {
        }
    }
}
