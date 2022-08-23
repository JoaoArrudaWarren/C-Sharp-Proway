using Console._0_TipoValor;
using System;
using System.Threading.Tasks;

namespace Console
{
    internal class Program
    {
        public static void Main()
        {
            BemVindo bem = new BemVindo();
            bem.Mensagem();
            TipoValor1 uaaa = new TipoValor1();
            uaaa.Executa();
            System.Console.WriteLine("caboo");
        }
    }
}
