using System.ComponentModel.DataAnnotations;

namespace XP_TesteTecnico.Context.Dtos
{
	public class CreateNomeDto
	{
		[Required(ErrorMessage = "O campo 'Nome Completo' é obrigatório")]
		public string NomeCompleto { get; set; }
    }
}
