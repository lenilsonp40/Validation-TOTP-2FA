using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Validation_TOTP_2FA.Models
{
    [Table("Validation_TB001_Clientes")]
    public class ClienteModel
    {
        [Key]
        public long ClienteId { get; set; }
        public string? Nome { get; set; }        
        public string? Email { get; set; }
        public string? Password { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
