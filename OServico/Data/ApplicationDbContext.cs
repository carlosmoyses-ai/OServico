using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OServico.Models;

namespace OServico.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<OServico.Models.Cliente> Cliente { get; set; }
        public DbSet<OServico.Models.OrdemServico> OrdemServico { get; set; }
        public DbSet<OServico.Models.Produto> Produto { get; set; }
        public DbSet<OServico.Models.Servico> Servico { get; set; }
        public DbSet<OServico.Models.Venda> Venda { get; set; }
    }
}