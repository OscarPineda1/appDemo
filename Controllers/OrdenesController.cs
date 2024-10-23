using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using appDemo.Models;

namespace appDemo.Controllers;

public class OrdenesController : Controller
{
    private readonly ILogger<OrdenesController> _logger;

    public OrdenesController(ILogger<OrdenesController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Ordenar(Ordenes ordenes)
    {
        List<Ordenes> listaOrdenes = new List<Ordenes>();
        listaOrdenes.Add(ordenes);
        ViewData["listaOrdenes"]=listaOrdenes;
        return View("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }


}