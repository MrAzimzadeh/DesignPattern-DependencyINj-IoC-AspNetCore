using Dependency_Injection_AspNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Dependency_Injection_AspNetCore.Services.Interface;

namespace Dependency_Injection_AspNetCore.Controllers
{
    public class HomeController : Controller
    {

        //private readonly ILog _log;

        //public HomeController(ILog log)
        //{
        //    _log = log;
        //}

        public IActionResult Index([FromServices] ILog log) // action bazli dependency injection da IoC Containerinden melumat getititik 
        {
            //_log.Log();
            log.Log();
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
}