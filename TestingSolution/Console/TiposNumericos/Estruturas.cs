namespace Console.TiposNumericos
{
    internal class Estruturas
    {
        public static void Executa()
        {
            PessoaFisica pessoa = new PessoaFisica();
            Pessoa pessoa1 = new Pessoa();

            pessoa.Nome = "JP";
            pessoa1.Nome = "Mi";

            System.Console.WriteLine(pessoa.Nome);
            System.Console.WriteLine(pessoa1.Nome);

            PessoaFisica pessoa2 = new PessoaFisica();
            pessoa2 = pessoa;
            Pessoa pessoa3 = new Pessoa();
            pessoa3 = pessoa1;

            System.Console.WriteLine(pessoa2.Nome);
            System.Console.WriteLine(pessoa3.Nome);

            pessoa.Nome = "JP Melhor";
            pessoa1.Nome = "MiMelhor";
            System.Console.WriteLine("Valor mudado");

            System.Console.WriteLine(pessoa.Nome);
            System.Console.WriteLine(pessoa1.Nome);
            System.Console.WriteLine(pessoa2.Nome);
            System.Console.WriteLine(pessoa3.Nome);
        }
    }
    internal struct Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
    internal class PessoaFisica
    {
        public string Nome { get => Nome.ToLower(); set => Nome = Nome.ToLower(); }
        private string Sobrenome { get; set; }
        private byte Idade { get; set; }
        private double money;
        public double GetMoney()
        {
            return money;
        }
        public void SetMoney(double money)
        {
            this.money = money;
        }
    }
}
