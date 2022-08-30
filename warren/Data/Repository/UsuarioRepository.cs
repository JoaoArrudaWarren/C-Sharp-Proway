using Data.Model;
using Data.Utils;

namespace Data.Repository
{
    public class UsuarioRepository : BaseRepository<Usuario>
    {
        public override string Create(Usuario model)
        {
            model.Password = Criptografia.Criptografar(model.Password);
            return base.Create(model);
        }
    }
}
