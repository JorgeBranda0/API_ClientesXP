using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using XP_TesteTecnico.Models;

namespace XP_TesteTecnico.Context.Dtos
{
	public class CreateDadoClienteDto
	{
		[Required(ErrorMessage = "O campo 'NomeId' é obrigatório")]
		public int NomeId { get; set; }

		[Required(ErrorMessage = "O campo 'TelefoneId' é obrigatório")]
		public int TelefoneId { get; set; }

		[Required(ErrorMessage = "O campo 'EmailId' é obrigatório")]
		public int EmailId { get; set; }
	}
}
