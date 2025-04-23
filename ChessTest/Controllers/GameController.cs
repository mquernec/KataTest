using System.Diagnostics;
using ChessTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChessTest.Controllers
{[Route("[controller]")]
[ApiController]
    public class GameController : ControllerBase
    {
        private static List<string> games = new ();
       [HttpPost]
       [Route("{agame}")]
        public IActionResult Post(string agame)
        {  
            games.Add(agame);
            return Ok();
        }

        [HttpGet]
        public IActionResult Index( )
        {  
            return Ok(games);
        }

        [HttpDelete]
            [Route("{agame}")]
        public IActionResult Del(string agame)
        {  
            games.Remove(agame);
            return Ok();
        }

    }
}