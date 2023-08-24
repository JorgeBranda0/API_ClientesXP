using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XP_TesteTecnico.Models
{
	[Table("Nome", Schema = "dbo")]
	public class NomeCliente
	{
		[Key]
		public int NomeId { get; set; }

		[Required(ErrorMessage = "O campo 'Nome Completo' é obrigatório")]
		public string NomeCompleto { get; set; }
    }
}
