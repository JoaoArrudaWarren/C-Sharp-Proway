using Console.TipoReferencia;
namespace Console
{
    internal class Program
    {
        public static void Main()
        {
            //_000cadastro oi = new _000cadastro();
            //oi.Cadastrar();
            //TiposNumericos3.Executa();
            //Enum.Executa();
            //Enum2.Executa();
            //Estruturas.Executa();
            Pessoa po = new Pessoa(nome: "");
            Pessoa poi = new Pessoa(nome: "", sobrenome: "");
            PessoaFisica pi = new PessoaFisica(nome: "", "", cpf: "22222");
            System.Console.WriteLine(poi.Saudacao());
            System.Console.WriteLine(po.Saudacao());
            System.Console.WriteLine(pi.Saudacao());
            Crud a = new Crud();
            System.Console.WriteLine(a.Create(pi));

        }
    }
}
