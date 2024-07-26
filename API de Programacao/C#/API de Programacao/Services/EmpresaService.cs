using API_de_Programacao.Domain.Entities;
using API_de_Programacao.Domain.Interfaces;
using API_de_Programacao.Domain.Interfaces.Repositorio;

namespace API_de_Programacao.Services;

public class EmpresaService : IEmpresaService
{

    private readonly IEmpresaRepository _empresaRepository;
    
    public EmpresaService(IEmpresaRepository empresaRepository)
    {
        _empresaRepository = empresaRepository;
    }

    public Empresa CadastrarEmpresa(Empresa empresa)
    {
        var retorno = _empresaRepository.CadastrarEmpresa(empresa);
        return retorno;
    }
}

