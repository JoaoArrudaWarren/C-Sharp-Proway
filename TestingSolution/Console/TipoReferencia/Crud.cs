using System.Collections.Generic;

namespace Console.TipoReferencia
{
    internal class Crud<T> : IRepository<T> where T : BaseModel
    {
        private List<T> pessoas;

        public Crud()
        {
            pessoas = new List<T>();
        }

        public string Create(T pessoa)
        {
            this.pessoas.Add(pessoa);
            return "Pessoa " + pessoa.Id + "Salva com sucesso";
        }

        public List<T> Read()
        {
            return pessoas;
        }

        public string Update(T pessoa)
        {

            return "Pessoa " + pessoa.Id + "foi alterada";
        }

        public string Delete(int id)
        {
            return "Pessoa de id:" + id + "Foi deletada";
        }
    }
}