using System;
namespace Console.TiposNumericos
{
    internal class Enum2
    {
        public static void Executa()
        {
            System.Console.WriteLine(DiasSemana2.DOM);
            DiasSemana2 diasPresenciais = (DiasSemana2)20;
            System.Console.WriteLine(diasPresenciais);
        }
    }
    [Flags]
    public enum DiasSemana2
    {
        DOM = 1, SEG = 2, TER = 4, QUA = 8, QUI = 16, SEX = 32, SAB = 64
    };
}
