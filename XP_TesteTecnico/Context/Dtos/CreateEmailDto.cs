using System.ComponentModel.DataAnnotations;

namespace XP_TesteTecnico.Context.Dtos
{
	public class CreateEmailDto
	{
        [Required(ErrorMessage = "O campo 'Email' é obrigatório")]
        public string Email { get; set; }
    }
}
