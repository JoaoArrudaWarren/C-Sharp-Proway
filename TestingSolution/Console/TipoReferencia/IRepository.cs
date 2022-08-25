using System.Collections.Generic;

namespace Console.TipoReferencia
{
    internal interface IRepository
    {

        string Create(Pessoa pessoa);

        string Update(Pessoa pessoa);

        string Delete(int id);

        List<Pessoa> Read();

    }
}
