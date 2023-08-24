using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XP_TesteTecnico.Models
{
	[Table("Email", Schema = "dbo")]
	public class EmailCliente
	{
		[Key]
		public int EmailId { get; set; }

		[Required(ErrorMessage = "O campo 'Email' é obrigatório")]
		public string Email { get; set; }
    }
}
