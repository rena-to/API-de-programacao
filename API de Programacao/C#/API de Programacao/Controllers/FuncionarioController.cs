using API_de_Programacao.Data;
using API_de_Programacao.Domain.Entities;
using API_de_Programacao.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API_de_Programacao.Controllers;

[ApiController]
[Route("api/[controller]")]

public class FuncionarioController : ControllerBase                                                                    
{
    private readonly IFuncionarioService _funcionarioService;

    public FuncionarioController(IFuncionarioService funcionarioService)
    {
        _funcionarioService = funcionarioService;
    }

    [HttpPost]
    public IActionResult CadastrarFuncionario([FromBody] Funcionario funcionario)
    {

        try
        {
            var retorno = _funcionarioService.CadastrarFuncionário(funcionario);
            return Ok(retorno);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.InnerException?.Message);
            return BadRequest(e.Message);
        }
        
    }
}
