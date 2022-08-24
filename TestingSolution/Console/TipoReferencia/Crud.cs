using System.Collections.Generic;

namespace Console.TipoReferencia
{
    internal class Crud
    {
        public string Create(PessoaFisica pessoa)
        {
            return "Pessoa " + pessoa.Nome + "Salva com sucesso";

        }

        public List<PessoaFisica> Read()
        {
            List<PessoaFisica> pessoas = new List<PessoaFisica>();
            return pessoas;
        }

        public string Update(PessoaFisica pessoa)
        {

            return "Pessoa " + pessoa.Nome + "foi alterada";
        }

        public string Delete(int id)
        {
            return "Pessoa de id:" + id + "Foi deletada";
        }
    }
}

