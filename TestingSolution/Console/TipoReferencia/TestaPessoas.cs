namespace Console.TipoReferencia
{
    internal class TestaPessoas
    {
        public static void Executar()
        {

            Pessoa po = new Pessoa(nome: "Renan", sobrenome: "Vieira");
            Pessoa poi = new Pessoa(nome: "Will", sobrenome: "Olivier");
            PessoaFisica pi = new PessoaFisica(nome: "JP", sobrenome: "Alves", cpf: "22222");
            PessoaFisica pio = new PessoaFisica(nome: "Millena", "Gurtler", cpf: "33333");
            Crud<Pessoa> a = new Crud<Pessoa>();
            a.Create(pi);
            a.Create(pio);
            a.Create(po);
            a.Create(poi);
            foreach (Pessoa pessoa in a.Read())
            {
                System.Console.WriteLine(pessoa.Saudacao());
            }

            Crud<Produto> b = new Crud<Produto>();

            Produto pro = new Produto();
            Produto proi = new Produto();
            Produto prio = new Produto();

            b.Create(prio);
            b.Create(pro);
            b.Create(proi);

            foreach (Produto produt in b.Read())
            {
                System.Console.WriteLine(produt.Id);
            }


            Table u = new Table();
            u.Nome = "Renan";
            System.Console.WriteLine(u.Nome);
        }

    }
}
