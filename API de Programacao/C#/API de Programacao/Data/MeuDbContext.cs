using API_de_Programacao.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_de_Programacao.Data;

public class MeuDbContext : DbContext
{
    public MeuDbContext(DbContextOptions<MeuDbContext> options) : base(options){}
    
    public DbSet<Empresa> Empresa { get; set; }
    public DbSet<Funcionario> Funcionario { get; set; }
    public DbSet<Produto> Produto { get; set; }
    public DbSet<Gestao> Gestao { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
            optionsBuilder.UseMySql("Server=localhost;Database=Gestor;User=root;Password=admin", 
                new MySqlServerVersion(new Version(8, 0, 21)));

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Funcionario>().HasKey(funcionario => funcionario.IdFuncionario);
        modelBuilder.Entity<Produto>().HasKey(produto => produto.IdProduto);
        modelBuilder.Entity<Empresa>().HasKey(empresa => empresa.IdEmpresa);
        modelBuilder.Entity<Gestao>().HasKey(gestao => gestao.IdGestao);
        
    }
}