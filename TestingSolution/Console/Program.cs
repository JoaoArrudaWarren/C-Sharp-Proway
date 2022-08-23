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
            TipoNumerico uaaa = new TipoNumerico();
            uaaa.Executa();
            System.Console.WriteLine("caboo");
        }
    }
}
