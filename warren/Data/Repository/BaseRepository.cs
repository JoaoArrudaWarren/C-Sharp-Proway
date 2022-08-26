using Data.Context;
using Data.Model;

namespace Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseModel
    {

        virtual public string Create(T model)
        {
            using (WarrenContext context = new WarrenContext())
            {
                context.Set<T>().Add(model);
                context.SaveChanges();
            }
            return "Criado";
        }

        virtual public string Delete(int id)
        {
            using (WarrenContext context = new WarrenContext())
            {
                context.Set<T>().Remove(context.Set<T>().ToList()[id]);
                context.SaveChanges();
            }
            return "Deletado";
        }

        virtual public List<T> GetAll()
        {
            using (WarrenContext context = new WarrenContext())
            {
                return context.Set<T>().ToList();
            }
        }

        virtual public T GetById(int id)
        {
            using (WarrenContext context = new WarrenContext())
            {
                return context.Set<T>().ToList()[id];
            }
        }

        virtual public string Update(T model)
        {
            return "Alterado";
        }
    }
}
