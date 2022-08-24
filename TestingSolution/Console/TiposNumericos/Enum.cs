namespace Console.TiposNumericos
{
    internal class Enum
    {
        public enum DiasSemana
        {
            DOM = 1, SEG, TER, QUA, QUI, SEX, SAB
        }
        public static void Executa()
        {
            System.Console.WriteLine(DiasSemana.DOM);
            System.Console.WriteLine((DiasSemana)2);
        }
    }
}