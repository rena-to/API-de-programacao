using API_de_Programacao.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_de_Programacao.Data;

public class MeuDbContext : DbContext
{
    public MeuDbContext(DbContextOptions<MeuDbContext> options) : base(options){}
    
    public DbSet<Empresa> Empresas { get; set; }
    public DbSet<Funcionario> Funcionarios { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Gestao> Gestoes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
            optionsBuilder.UseMySql("Server=127.0.0.1;Database=Gestor;User=root;Password=1234", 
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