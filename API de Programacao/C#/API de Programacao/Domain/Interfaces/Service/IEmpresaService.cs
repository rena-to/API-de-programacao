using API_de_Programacao.Domain.Entities;

namespace API_de_Programacao.Domain.Interfaces;

public interface IEmpresaService
{
    Empresa CadastrarEmpresa(Empresa empresa);
}