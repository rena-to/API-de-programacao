using API_de_Programacao.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_de_Programacao.Controllers;

[ApiController]
[Route("[controller]")]
public class ConexaoController : ControllerBase
{
    private readonly MeuDbContext _meuDbContext;

    public ConexaoController(IConfiguration configuration, MeuDbContext meuDbContext)
    {
        _meuDbContext = meuDbContext;
    }

    [HttpGet("teste-conexao-entity")]
    public IActionResult TesteEntity()
    {
        try
        {
            _meuDbContext.Database.OpenConnection();
            _meuDbContext.Database.CloseConnection();
            return Ok("Conexão realizada com sucesso");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"A conexão falhou: {ex.Message}");
        }
    }
}