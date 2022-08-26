using System.Collections.Generic;

namespace Console.TipoReferencia
{
    internal class Produto : BaseModel
    {

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string Create(Produto pessoa)
        {
            throw new System.NotImplementedException();
        }

        public string Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Produto> Read()
        {
            throw new System.NotImplementedException();
        }

        public string Update(Produto pessoa)
        {
            throw new System.NotImplementedException();
        }
    }
}
