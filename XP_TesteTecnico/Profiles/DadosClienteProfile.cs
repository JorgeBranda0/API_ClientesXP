using AutoMapper;
using XP_TesteTecnico.Context.Dtos;
using XP_TesteTecnico.Models;

namespace XP_TesteTecnico.Profiles
{
	public class DadosClienteProfile : Profile
	{
		public DadosClienteProfile() 
		{
			CreateMap<CreateNomeDto, NomeCliente>();
			CreateMap<CreateEmailDto, EmailCliente>();
			CreateMap<CreateTelefoneDto, TelefoneCliente>();
			CreateMap<CreateDadoClienteDto, DadoCliente>();
		}
	}
}
