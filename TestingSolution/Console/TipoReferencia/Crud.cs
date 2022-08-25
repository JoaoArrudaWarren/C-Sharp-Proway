using System.Collections.Generic;

namespace Console.TipoReferencia
{
    internal class Crud : IRepository
    {
        private List<Pessoa> pessoas;

        public Crud()
        {
            pessoas = new List<Pessoa>();
        }

        public string Create(Pessoa pessoa)
        {
            this.pessoas.Add(pessoa);
            return "Pessoa " + pessoa.Nome + "Salva com sucesso";
        }

        public List<Pessoa> Read()
        {
            return pessoas;
        }

        public string Update(Pessoa pessoa)
        {

            return "Pessoa " + pessoa.Nome + "foi alterada";
        }

        public string Delete(int id)
        {
            return "Pessoa de id:" + id + "Foi deletada";
        }
    }
}