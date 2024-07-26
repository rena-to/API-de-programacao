using API_de_Programacao.Data;
using API_de_Programacao.Domain.Entities;
using API_de_Programacao.Domain.Interfaces.Repositorio;

namespace API_de_Programacao.Repositories;

public class EmpresaRepository : IEmpresaRepository
{
    private readonly MeuDbContext _meuDbContext;

    public EmpresaRepository(MeuDbContext meuDbContext)
    {
        _meuDbContext = meuDbContext;
    }

    public Empresa CadastrarEmpresa(Empresa empresa)
    {
        _meuDbContext.Empresa.Add(empresa);
        _meuDbContext.SaveChanges();

        return empresa;
    }
}