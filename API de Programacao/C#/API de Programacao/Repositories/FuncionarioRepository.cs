using API_de_Programacao.Data;
using API_de_Programacao.Domain.Entities;
using API_de_Programacao.Domain.Interfaces.Repositorio;

namespace API_de_Programacao.Repositories;

public class FuncionarioRepository : IFuncionarioRepository
{

    private readonly MeuDbContext _meuDbContext;

    public FuncionarioRepository(MeuDbContext meuDbContext)
    {
        _meuDbContext = meuDbContext;
    }

    public Funcionario CadastrarFuncionario(Funcionario funcionario)
    {
        _meuDbContext.Funcionarios.Add(funcionario);
        _meuDbContext.SaveChanges();

        return funcionario;
    }
}