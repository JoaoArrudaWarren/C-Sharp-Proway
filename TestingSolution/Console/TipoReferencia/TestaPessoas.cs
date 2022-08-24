namespace Console.TipoReferencia
{
    internal class TestaPessoas
    {
        public static void Executar()
        {
            Pessoa po = new Pessoa(nome: "Renan", sobrenome: "Vieira");
            Pessoa poi = new Pessoa(nome: "Will", sobrenome: "Olivier");
            PessoaFisica pi = new PessoaFisica(nome: "JP", "Alves", cpf: "22222");
            PessoaFisica pio = new PessoaFisica(nome: "Millena", "Gurtler", cpf: "33333");
            Crud a = new Crud();
            a.Create(pi);
            a.Create(pio);
            a.Create(po);
            a.Create(poi);
            foreach (Pessoa pessoa in a.Read())
            {
                System.Console.WriteLine(pessoa.Saudacao());
            }
        }
    }
}
