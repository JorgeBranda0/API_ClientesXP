using System.Text.RegularExpressions;
using XP_TesteTecnico.Interfaces;

namespace XP_TesteTecnico.Services
{
	public class ValidarComponenteService : IValidarComponente
	{
		public bool Email(string email)
		{
			string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
			return Regex.IsMatch(email, pattern);
		}

		public bool Telefone(string telefone)
		{
			telefone = Regex.Replace(telefone, @"[^\d]", "");
			return ValidaNumeroCelular(telefone) || ValidaNumeroFixo(telefone);
		}

		private bool ValidaNumeroCelular(string telefone)
		{
			string pattern = @"^\d{11}$";
			return Regex.IsMatch(telefone, pattern);
		}

		private bool ValidaNumeroFixo(string telefone)
		{
			string pattern = @"^\d{10}$";
			return Regex.IsMatch(telefone, pattern);
		}
	}
}
