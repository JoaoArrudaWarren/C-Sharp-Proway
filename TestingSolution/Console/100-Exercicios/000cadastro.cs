namespace Console._100_Exercicios
{
    public class _000cadastro
    {
        public void Cadastrar()
        {
            System.Console.WriteLine("Saudações!");
            System.Console.WriteLine(" Digite seu nome: ");
            string nome = System.Console.ReadLine();
            System.Console.WriteLine(" Digite seu sobrenome: ");
            string sobrenome = System.Console.ReadLine();
            System.Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Olá, " + nome + " " + sobrenome + ", de idade " + idade);
        }
    }
}
