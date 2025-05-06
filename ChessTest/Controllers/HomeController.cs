using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace ChessTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IChessGameService _service;

        public HomeController(ILogger<HomeController> logger, IChessGameService service)
        {
            _service = service;
            _logger = logger;
        }
    
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ValidateMove([FromBody] MoveViewModel aMove)
        {
            Console.WriteLine("ValidateMove");
            if (_service.ValidateMove(aMove.Game, aMove.FromFen, aMove.ToFen))
                return Ok();
            return BadRequest("Invalid move.");
        }

    }
}
