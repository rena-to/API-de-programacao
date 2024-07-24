using API_de_Programacao.Data;
using API_de_Programacao.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_de_Programacao.Controllers;

public class VendaController : Controller
{
    private readonly MeuDbContext _context;

    public VendaController(MeuDbContext context)
    {
        _context = context;
    }

}
