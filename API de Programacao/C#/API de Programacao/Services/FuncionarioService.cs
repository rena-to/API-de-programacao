using API_de_Programacao.Domain.Entities;
using API_de_Programacao.Domain.Interfaces;
using API_de_Programacao.Domain.Interfaces.Repositorio;

namespace API_de_Programacao.Services;

public class FuncionarioService : IFuncionarioService
{
    private readonly IFuncionarioRepository _funcionarioRepository;

    public FuncionarioService(IFuncionarioRepository funcionarioRepository)
    {
        _funcionarioRepository = funcionarioRepository;
    }

    public Funcionario CadastrarFuncionário(Funcionario funcionario)
    {
        var retorno = _funcionarioRepository.CadastrarFuncionario(funcionario);
        return retorno;
    }
}