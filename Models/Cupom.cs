using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CupomDesconto.Models
{
    public class Cupom
    {
        [Key]
        public int Id { get; set; }

        public string Codigo { get; set; }

        [Display(Name = "Valor de Desconto")]
        public decimal? Valor_Desconto { get; set; }

        [Display(Name = "Percentual de Desconto")]
        public decimal? Percentual_Desconto { get; set; }

        [Display(Name = "Data de Validade")]
        public DateTime? DataValidade { get; set; }

        [Required(ErrorMessage = "O ID do usuário é obrigatório")]
        public int UsuarioID { get; set; }

        [ForeignKey("UsuarioID")]
        public Usuario Usuario { get; set; }

        [Required(ErrorMessage = "O ID da loja é obrigatório")]
        public int LojaID { get; set; }

        [ForeignKey("LojaID")]
        public Loja Loja { get; set; }

        [Required(ErrorMessage = "O ID do produto é obrigatório")]
        public int ProdutoID { get; set; }

        [ForeignKey("ProdutoID")]
        public Produto Produto { get; set; }
    }
}
