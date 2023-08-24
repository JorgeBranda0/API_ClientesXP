using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XP_TesteTecnico.Models
{
	[Table("DadosCliente", Schema = "dbo")]
	public class DadoCliente
	{
		[Key]
		public int ClienteId { get; set; }

        [ForeignKey("Nome")]
		public int NomeId { get; set; }

		[ForeignKey("Email")]
		public int EmailId { get; set; }

        [ForeignKey("Telefone")]
		public int TelefoneId { get; set; }

        public virtual NomeCliente Nome { get; set; }
		public virtual EmailCliente Email { get; set; }
		public virtual TelefoneCliente Telefone { get; set; }
	}
}
