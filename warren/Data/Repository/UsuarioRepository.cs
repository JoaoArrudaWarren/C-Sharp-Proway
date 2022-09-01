using Data.Context;
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

        public Usuario Logon(string email, string password)
        {
            password = Criptografia.Criptografar(password);
            Usuario usuario = new Usuario();
            using (WarrenContext context = new())
            {
                usuario = context.Usuario.Where(u => u.Email == email && u.Password == password).FirstOrDefault();
            }
            return usuario;
        }
    }
}
