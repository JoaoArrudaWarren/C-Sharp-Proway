using System.Collections.Generic;

namespace Console.TipoReferencia
{
    internal interface IRepository<T>
    {

        string Create(T pessoa);

        string Update(T pessoa);

        string Delete(int id);

        List<T> Read();

    }
}
