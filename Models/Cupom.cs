using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

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
        public int UsuarioId { get; set; }

        //[ForeignKey("UsuarioID")]
        [ValidateNever]
        public Usuario Usuario { get; set; }

        [Required(ErrorMessage = "O ID da loja é obrigatório")]
        public int LojaId { get; set; }

        //[ForeignKey("LojaID")]
        [ValidateNever]
        public Loja Loja { get; set; }

        [Required(ErrorMessage = "O ID do produto é obrigatório")]
        public int ProdutoId { get; set; }

        //[ForeignKey("ProdutoID")]
        [ValidateNever]
        public Produto Produto { get; set; }
    } 
}
