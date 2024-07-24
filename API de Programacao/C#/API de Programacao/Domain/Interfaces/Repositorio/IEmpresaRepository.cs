using API_de_Programacao.Domain.Entities;

namespace API_de_Programacao.Domain.Interfaces.Repositorio;

public interface IEmpresaRepository
{
    Empresa CadastrarEmpresa(Empresa empresa);
}