namespace Console.TipoReferencia
{
    internal class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }
        public PessoaFisica()
        {
        }
        public PessoaFisica(string nome, string sobrenome, string cpf)
        {
            this.Cpf = cpf;
            base.Nome = nome;
            base.Sobrenome = sobrenome;
        }

        override public string Saudacao()
        {
            return base.Saudacao() + " " + Cpf;
        }
    }
}
