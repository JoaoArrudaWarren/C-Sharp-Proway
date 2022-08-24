namespace Console.TipoReferencia
{
    internal class PessoaJuridica : Pessoa
    {

        public string Cnpj { get; set; }

        public PessoaJuridica(string nome, string sobrenome, string cnpj) : base(nome, sobrenome)
        {
            this.Cnpj = cnpj;
        }

        override public string Saudacao()
        {

            return base.Saudacao() + Cnpj;
        }

    }
}
