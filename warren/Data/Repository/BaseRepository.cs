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
                context.Set<T>().Remove(context.Set<T>().Find(id));
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
                return context.Set<T>().Find(id);
            }
        }

        virtual public string Update(T model)
        {
            using (WarrenContext context = new())
            {
                context.Entry<T>(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
            return "Alterado";
        }
        virtual public string Modify(T model)
        {
            using (WarrenContext context = new())
            {
                context.Entry<T>(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
            return "Alterado";
        }
    }
}
