using System.ComponentModel.DataAnnotations;

namespace CupomDesconto.Models
{
    public class Loja
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "é obrigatório")]
        public string Nome { get; set; }
    }
}
