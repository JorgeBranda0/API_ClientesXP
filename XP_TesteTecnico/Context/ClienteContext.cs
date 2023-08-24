using Microsoft.EntityFrameworkCore;
using XP_TesteTecnico.Models;

namespace XP_TesteTecnico.Context
{
	public class ClienteContext : DbContext
	{
		public ClienteContext(DbContextOptions<ClienteContext> options) : base(options)
		{
		}

		public DbSet<NomeCliente> Nomes { get; set; }
		public DbSet<TelefoneCliente> Telefones { get; set; }
        public DbSet<EmailCliente> Emails { get; set; }
        public DbSet<DadoCliente> DadosClientes { get; set; }
    }
}
