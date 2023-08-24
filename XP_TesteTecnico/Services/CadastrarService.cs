using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using XP_TesteTecnico.Context;
using XP_TesteTecnico.Context.Dtos;
using XP_TesteTecnico.Interfaces;
using XP_TesteTecnico.Models;

namespace XP_TesteTecnico.Services
{
	public class CadastrarService : ICadastrar
	{
		private ClienteContext _context;
		private IMapper _mapper;
		private IValidarComponente _validarComponente;

		public CadastrarService(ClienteContext context, IMapper mapper, IValidarComponente validarComponente) 
		{
			_context = context;
			_mapper = mapper;
			_validarComponente = validarComponente;
		}

		public async Task<bool> CadastraNome([FromBody] CreateNomeDto nomeDto)
		{
			NomeCliente nome = _mapper.Map<NomeCliente>(nomeDto);

			if (!string.IsNullOrEmpty(nome.NomeCompleto))
			{
				_context.Nomes.Add(nome);
				await _context.SaveChangesAsync();
				return true;
			}

			return false;
		}

		public async Task<bool> CadastraTelefone([FromBody] CreateTelefoneDto telefoneDto)
		{
			TelefoneCliente telefone = _mapper.Map<TelefoneCliente>(telefoneDto);

			if (_validarComponente.Telefone(telefone.Telefone))
			{
				_context.Telefones.Add(telefone);
				await _context.SaveChangesAsync();
				return true;
			}

			return false;
		}

		public async Task<bool> CadastraEmail([FromBody] CreateEmailDto emailDto)
		{
			EmailCliente email = _mapper.Map<EmailCliente>(emailDto);

			if (_validarComponente.Email(email.Email))
			{
				_context.Emails.Add(email);
				await _context.SaveChangesAsync();
				return true;
			}

			return false;
		}

		public async Task<bool> InsereDadoCliente([FromBody] CreateDadoClienteDto dadosClienteDto)
		{
			DadoCliente dadosCliente = _mapper.Map<DadoCliente>(dadosClienteDto);

			if (dadosCliente != null) 
			{
				_context.DadosClientes.Add(dadosCliente);
				await _context.SaveChangesAsync();
				return true;
			}

			return false;
		}
	}
}
