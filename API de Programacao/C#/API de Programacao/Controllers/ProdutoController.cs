using API_de_Programacao.Data;
using Microsoft.AspNetCore.Mvc;

namespace API_de_Programacao.Controllers;

public class ProdutoController : Controller
{
    private readonly MeuDbContext _context;

    public ProdutoController(MeuDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var produtos = _context.Produto.ToList();
        return View(produtos);
    }

    // Outros métodos CRUD
}
