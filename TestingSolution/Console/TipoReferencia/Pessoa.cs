namespace Console.TipoReferencia
{
    public class Pessoa : BaseModel
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public Pessoa() { }

        public Pessoa(string nome, string sobrenome = "Ailton")
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        virtual public string Saudacao()
        {
            return "Ola, " + Nome + " " + Sobrenome;
        }

    }
}
