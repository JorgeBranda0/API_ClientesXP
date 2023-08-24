using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XP_TesteTecnico.Models
{
	[Table("Telefone", Schema = "dbo")]
	public class TelefoneCliente
	{
		[Key]
		public int TelefoneId { get; set; }

		[Required(ErrorMessage = "O campo 'Telefone' é obrigatório")]
		public string Telefone { get; set; }
    }
}
