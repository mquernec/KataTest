using System.Diagnostics;
using ChessTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChessTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ValidateMove([FromBody] MoveViewModel aMove)
        {   Console.WriteLine("ValidateMove");
            Console.WriteLine(aMove.Move);
            return Ok();
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
