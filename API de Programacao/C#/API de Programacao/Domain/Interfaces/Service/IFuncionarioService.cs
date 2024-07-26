using API_de_Programacao.Domain.Entities;

namespace API_de_Programacao.Domain.Interfaces;

public interface IFuncionarioService
{
    Funcionario CadastrarFuncionário(Funcionario funcionario);
}