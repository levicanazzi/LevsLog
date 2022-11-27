using ApiLevsLog.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiLevsLog.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cliente>()
                .HasOne(cliente => cliente.Endereco)
                .WithOne(endereco => endereco.Cliente)
                .HasForeignKey<Cliente>(cliente => cliente.IdEndereco);

            modelBuilder.Entity<Orcamento>()
                .HasOne(orcamento => orcamento.TipoServico)
                .WithOne(tipoServico => tipoServico.Orcamento)
                .HasForeignKey<Orcamento>(orcamento => orcamento.IdTipoServico);

            modelBuilder.Entity<Orcamento>()
                .HasOne(orcamento => orcamento.Endereco)
                .WithOne(endereco => endereco.Orcamento)
                .HasForeignKey<Orcamento>(orcamento => orcamento.IdEndereco)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Orcamento>()
                .HasOne(orcamento => orcamento.Cliente)
                .WithMany(cliente => cliente.Orcamentos)
                .HasForeignKey(orcamento => orcamento.IdCliente);

            modelBuilder.Entity<Produto>()
                .HasOne(produto => produto.Orcamento)
                .WithMany(orcamento => orcamento.Produtos)
                .HasForeignKey(produto => produto.IdOrcamento);
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Enderecos> Enderecos { get; set; }
        public DbSet<Orcamento> Orcamentos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<TipoServico> TipoServicos { get; set; }
    }
}
