using System.ComponentModel.DataAnnotations;

namespace CupomDesconto.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "é obrigatório")]
        public string Nome { get; set; }
        [Display(Name = "Preço")]
        public decimal? Preco { get; set; }
    }
}
