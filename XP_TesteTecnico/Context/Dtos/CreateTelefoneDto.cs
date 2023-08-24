using System.ComponentModel.DataAnnotations;

namespace XP_TesteTecnico.Context.Dtos
{
	public class CreateTelefoneDto
	{
        [Required(ErrorMessage = "O campo 'Telefone' é obrigatório")]
		public string Telefone { get; set; }
    }
}
