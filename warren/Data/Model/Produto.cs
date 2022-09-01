using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Model
{
    public class Produto : BaseModel
    {
        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public int CategoriaId { get; set; }

        [ForeignKey("CategoriaId")]
        public Categoria? Categoria { get; set; }
    }
}
