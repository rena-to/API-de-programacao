using API_de_Programacao.Data;
using API_de_Programacao.Domain.Entities;
using API_de_Programacao.Domain.Interfaces;
using API_de_Programacao.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_de_Programacao.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmpresaController : ControllerBase
{
    private readonly IEmpresaService _empresaService;

    public EmpresaController(IEmpresaService empresaService)
    {
        _empresaService = empresaService;
    }

    // POST: api/Empresa
    [HttpPost]
    public IActionResult CadastrarEmpresa([FromBody] Empresa empresa)
    {
        try
        {
            var retorno = _empresaService.CadastrarEmpresa(empresa);
            return Ok(retorno);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

}
