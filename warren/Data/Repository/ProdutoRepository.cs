using Data.Context;
using Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository
{
    public class ProdutoRepository : BaseRepository<Produto>
    {
        public override List<Produto> GetAll()
        {
            List<Produto> list = new();

            using (WarrenContext context = new())
            {
                list = context.Produto.Include("Categoria").ToList();
            }
            return list;
        }
    }
}
