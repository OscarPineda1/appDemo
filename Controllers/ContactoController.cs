using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using appDemo.Models;

namespace appDemo.Controllers;

public class ContactoController : Controller
{
    private readonly ILogger<ContactoController> _logger;

    public ContactoController(ILogger<ContactoController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Registrar(Contacto contacto)
    {
        ViewData["MsgRespuesta"] = "Gracias por conctactarnos, nos ponemos en contacto pronto " + contacto.Nombre;
        return View("Index");
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

public class Contacto
{
    public string? Nombre {get; set;}
    public string? Email {get; set;}
    public string? Mensaje {get; set;}

    public int? Edad {get; set;}

}