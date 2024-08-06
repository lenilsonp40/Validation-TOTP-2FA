using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_Validation_TOTP_2FA.Models
{
    [Table("Validation_TB002_Produtos")]
    public class ProdutoModel
    {
        [Key]
        public int ProdutoId { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public decimal Preco { get; set; }
        public string? ImagemUrl { get; set; }
        public float Estoque { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
