using Microsoft.AspNetCore.Mvc;

namespace GrimoriumRPG.Api.Controller
{
    [ApiController]
    [Route("api/[controller]")] // Padrão recomendado: lê o nome da classe 'Campanhas'
    public class CampanhasController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            Console.WriteLine("[PING] Requisição GET recebida!");
            return Ok(new { mensagem = "API do GRIMORIUM RPG está funcionando!", data = DateTime.Now });
        }
    }
}