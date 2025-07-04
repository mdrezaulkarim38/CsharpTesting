using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LearningMVC.Models;
using LearningMVC.Interfaces;

namespace LearningMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IProductService _service;

    public HomeController(ILogger<HomeController> logger, IProductService productService)
    {
        _logger = logger;
        _service = productService;
    }

    public IActionResult Index()
    {
        return View();
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
