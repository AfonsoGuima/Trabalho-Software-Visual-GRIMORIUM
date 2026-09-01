using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class DnDController : ControllerBase
{

    [HttpGet("ability-scores")]
    [HttpGet("classes")]
    [HttpGet("conditions")]
    [HttpGet("damage-types")]
    [HttpGet("equipment-categories")]
    [HttpGet("equipment")]
    [HttpGet("features")]
    [HttpGet("languages")]
    [HttpGet("magic-schools")]
    [HttpGet("monsters")]
    [HttpGet("proficiencies")]
    [HttpGet("races")]
    [HttpGet("skills")]
    [HttpGet("spells")]
    [HttpGet("subclasses")]
    [HttpGet("subraces")]
    [HttpGet("traits")]
    [HttpGet("weapon-properties")]
    public async Task<IActionResult> ObterTodos()
    {
       
        string categoria = HttpContext.Request.Path.Value?.TrimStart('/').Split('/')[2] ?? "";

        var json = await DnDRepository.ObterTodosPorCategoriaAsync(categoria);

        if (json == null)
            return StatusCode(503, new { mensagem = $"Unable to fetch data for '{categoria}' from DnD API." });

        return Content(json, "application/json");
    }


    [HttpGet("ability-scores/{nome}")]
    [HttpGet("classes/{nome}")]
    [HttpGet("conditions/{nome}")]
    [HttpGet("damage-types/{nome}")]
    [HttpGet("equipment-categories/{nome}")]
    [HttpGet("equipment/{nome}")]
    [HttpGet("features/{nome}")]
    [HttpGet("languages/{nome}")]
    [HttpGet("magic-schools/{nome}")]
    [HttpGet("monsters/{nome}")]
    [HttpGet("proficiencies/{nome}")]
    [HttpGet("races/{nome}")]
    [HttpGet("skills/{nome}")]
    [HttpGet("spells/{nome}")]
    [HttpGet("subclasses/{nome}")]
    [HttpGet("subraces/{nome}")]
    [HttpGet("traits/{nome}")]
    [HttpGet("weapon-properties/{nome}")]
    public async Task<IActionResult> ObterPorNome(string nome)
    {
        string categoria = HttpContext.Request.Path.Value?.TrimStart('/').Split('/')[2] ?? "";

        var json = await DnDRepository.ObterPorCategoriaENomeAsync(categoria, nome);

        if (json == null)
            return NotFound(new { mensagem = $"Item '{nome}' not found in '{categoria}'." });

        return Content(json, "application/json");
    }
}