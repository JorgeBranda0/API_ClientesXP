using Microsoft.AspNetCore.Mvc;
using XP_TesteTecnico.Context.Dtos;

namespace XP_TesteTecnico.Interfaces
{
	public interface ICadastrar
	{
		Task<bool> CadastraNome([FromBody] CreateNomeDto nomeDto);
		Task<bool> CadastraTelefone([FromBody] CreateTelefoneDto telefoneDto);
		Task<bool> CadastraEmail([FromBody] CreateEmailDto emailDto);
		Task<bool> InsereDadoCliente([FromBody] CreateDadoClienteDto dadosClienteDto);

	}
}
