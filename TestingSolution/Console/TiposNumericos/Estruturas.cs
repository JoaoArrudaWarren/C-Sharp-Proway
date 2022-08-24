namespace Console.TiposNumericos
{
    internal class Estruturas
    {
        public static void Executa()
        {
            PessoasFisicas pessoa = new PessoasFisicas();
            Pessoas pessoa1 = new Pessoas();

            pessoa.Nome = "JP";
            pessoa1.Nome = "Mi";

            System.Console.WriteLine(pessoa.Nome);
            System.Console.WriteLine(pessoa1.Nome);

            PessoasFisicas pessoa2 = new PessoasFisicas();
            pessoa2 = pessoa;
            Pessoas pessoa3 = new Pessoas();
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
    internal struct Pessoas
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
    internal class PessoasFisicas
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
