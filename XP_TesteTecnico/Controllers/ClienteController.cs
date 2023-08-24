using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using XP_TesteTecnico.Context;
using XP_TesteTecnico.Context.Dtos;
using XP_TesteTecnico.Interfaces;
using XP_TesteTecnico.Models;

namespace XP_TesteTecnico.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ClienteController : ControllerBase
	{
		private ICadastrar _cadastrar;
		private ClienteContext _context;
		private bool processo;

		public ClienteController(ICadastrar cadastrar, ClienteContext context)
		{
			_cadastrar = cadastrar;
			_context = context;
		}

		#region CadastraNome
		[HttpPost("CadastraNome")]
		public async Task<IActionResult> CadastraNome([FromBody] CreateNomeDto nomeDto)
		{
			processo = await _cadastrar.CadastraNome(nomeDto);
			return RetornaProcesso(processo);
		}
		#endregion

		#region CadastraTelefone
		[HttpPost("CadastraTelefone")]
		public async Task<IActionResult> CadastraTelefone([FromBody] CreateTelefoneDto telefoneDto)
		{
			processo = await _cadastrar.CadastraTelefone(telefoneDto);
			return RetornaProcesso(processo);
		}
		#endregion

		#region CadastraEmail
		[HttpPost("CadastraEmail")]
		public async Task<IActionResult> CadastraEmail([FromBody] CreateEmailDto emailDto)
		{
			processo = await _cadastrar.CadastraEmail(emailDto);
			return RetornaProcesso(processo);
		}
		#endregion

		#region InsereDadoCliente
		[HttpPost("InsereDadoCliente")]
		public async Task<IActionResult> InsereDadoCliente([FromBody] CreateDadoClienteDto dadoClienteDto)
		{
			processo = await _cadastrar.InsereDadoCliente(dadoClienteDto);
			return RetornaProcesso(processo);
		}
		#endregion

		#region RecuperaNomes
		[HttpGet("RecuperaNomes")]
		public IEnumerable<NomeCliente> RecuperaNomes()
		{
			return _context.Nomes;
		}
		#endregion

		#region RecuperaTelefones
		[HttpGet("RecuperaTelefones")]
		public IEnumerable<TelefoneCliente> RecuperaTelefones()
		{
			return _context.Telefones;
		}
		#endregion

		#region RecuperaEmails
		[HttpGet("RecuperaEmails")]
		public IEnumerable<EmailCliente> RecuperaEmails()
		{
			return _context.Emails;
		}
		#endregion

		#region RecuperaDadosClientes
		[HttpGet("RecuperaDadosClientes")]
		public List<ReadDadoClienteDto> RecuperaDadosClientes()
		{
			List<DadoCliente> dados = new();
			List<ReadDadoClienteDto> dadosDto = new();

			try
			{
				dados = _context.DadosClientes.Include(p => p.Nome)
											  .Include(p => p.Telefone)
											  .Include(p => p.Email).ToList();
				foreach (var item in dados)
				{
					dadosDto.Add(new ReadDadoClienteDto
					{
						Id = item.ClienteId,
						NomeCompleto = item.Nome.NomeCompleto,
						Email = item.Email.Email,
						Telefone = item.Telefone.Telefone
					});
				}

				return dadosDto;
			}
			catch (Exception ex)
			{
				throw new Exception("Não foi possível finalizar o processo! Mensagem de erro: " + ex.Message);
			}
		}
		#endregion

		#region RetornaProcesso
		private IActionResult RetornaProcesso(bool processo)
		{
			if (processo)
				return Ok("Cadastro realizado com sucesso!");
			else
				return BadRequest("Erro ao finalizar o processo de cadastro! " +
								  "Verifique se os campos foram digitados corretamente.");
		}
		#endregion
	}
}
