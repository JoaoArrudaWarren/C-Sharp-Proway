using Data.Model;

namespace Data.Repository
{
    public interface IRepository<T> where T : BaseModel
    {
        string Create(T model);

        string Update(T model);

        string Delete(int id);

        List<T> GetAll();

        T GetById(int id);

        string Modify(T model);
    }
}
