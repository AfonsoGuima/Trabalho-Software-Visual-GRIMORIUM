using Microsoft.AspNetCore.Mvc;

namespace GrimoriumRPG.Api.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class CampanhasController : ControllerBase
    {
        // Espaço para interação com o DbContext futuramente.

        [HttpGet("ping")]
        public IActionResult Ping()
        {
            return Ok(new { mensagem = "API do GRIMORIUM RPG está funcionando!", data = DateTime.Now });
        }
    }
}