using GrimoriumRPG.Api.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GrimoriumRPG.Api.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class Tormenta20Controller : ControllerBase
    {
        [HttpGet("divindades")]
        public IActionResult ObterDivindades()
        {
            var json = Tormenta20Repository.ObterTodasDivindades();
            if (json == null) return NotFound(new { mensagem = "Arquivo de divindades não encontrado." });

            return Content(json, "application/json");
        }

        [HttpGet("divindades/{nome}")]
        public IActionResult ObterDivindadePorNome(string nome)
        {
            var json = Tormenta20Repository.ObterDivindadePorNome(nome);
            if (json == null) return NotFound(new { mensagem = $"Divindade '{nome}' não foi encontrada." });

            return Content(json, "application/json");
        }

        [HttpGet("habilidades")]
        public IActionResult ObterHabilidades()
        {
            var json = Tormenta20Repository.Habilidades();
            if (json == null) return NotFound(new { mensagem = "Arquivo de habilidades não encontrado." });

            return Content(json, "application/json");
        }

        [HttpGet("habilidades/{nome}")]
        public IActionResult ObterHabilidadePorNome(string nome)
        {
            var json = Tormenta20Repository.ObterHabilidadePorNome(nome);
            if (json == null) return NotFound(new { mensagem = $"Habilidade '{nome}' não foi encontrada." });

            return Content(json, "application/json");
        }

        [HttpGet("racas")]
        public IActionResult ObterRacas()
        {
            var json = Tormenta20Repository.Racas();
            if (json == null) return NotFound(new { mensagem = "Arquivo de raças não encontrado." });

            return Content(json, "application/json");
        }

        
        [HttpGet("racas/{nome}")]
        public IActionResult ObterRacaPorNome(string nome)
        {
            var json = Tormenta20Repository.ObterRacaPorNome(nome);
            if (json == null) return NotFound(new { mensagem = $"Raça '{nome}' não foi encontrada." });

            return Content(json, "application/json");
        }

        [HttpGet("pericias")]
        public IActionResult ObterPericias()
        {
            var json = Tormenta20Repository.pericias();
            if (json == null) return NotFound(new { mensagem = "Arquivo de perícias não encontrado." });

            return Content(json, "application/json");
        }

        [HttpGet("pericias/{nome}")]
        public IActionResult ObterPericiaPorNome(string nome)
        {
            var json = Tormenta20Repository.ObterPericiaPorNome(nome);
            if (json == null) return NotFound(new { mensagem = $"Perícia '{nome}' não foi encontrada." });

            return Content(json, "application/json");
        }

        [HttpGet("classes")]
        public IActionResult ObterHabilidadesPorClasse()
        {
            var json = Tormenta20Repository.classes();
            if (json == null) return NotFound(new { mensagem = "Arquivo de classes não encontrado." });
            

            return Content(json, "application/json");
        }


        [HttpGet("classes/{nome}")]
        public IActionResult ObterClasse(string nome)
        {
            var json = Tormenta20Repository.ObterClassePorNome(nome);
            if (json == null) return NotFound(new { mensagem = $"Classe '{nome}' não foi encontrada." });

            return Content(json, "application/json");
        }


        [HttpGet("classes/{nome}/{habilidade}")]
        public IActionResult ObterHabilidadesPorClasse(string nome, string habilidade)
        {
            var json = Tormenta20Repository.ObterHabilidadesPorClasse(nome, habilidade);
            if (json == null) return NotFound(new { mensagem = $"Habilidade '{habilidade}' não foi encontrada para a classe '{nome}'." });

            return Content(json, "application/json");
        }

        [HttpGet("classes/{classe}/tabelanivel")]
        public IActionResult ObterTabelaNivel(string classe)
        {
            var jsonTabela = Tormenta20Repository.ObterTabelaNivelPorClasse(classe);

            if (jsonTabela == null)
            {
                return NotFound(new { mensagem = $"Tabela de nível não encontrada para a classe '{classe}'." });
            }

            // Retorna o JSON da tabela puro (HTTP status 200 OK)
            return Content(jsonTabela, "application/json");
        }


        [HttpGet("classes/{classe}/proeficiencias")]
        public IActionResult ObterProeficiencias(string classe)
        {
            var jsonProeficiencias = Tormenta20Repository.ObterProeficienciasPorClasse(classe);

            if (jsonProeficiencias == null)
            {
                return NotFound(new { mensagem = $"Proeficiências não encontradas para a classe '{classe}'." });
            }

            // Retorna o JSON envelopado (HTTP status 200 OK)
            return Content(jsonProeficiencias, "application/json");
        }

        [HttpGet("classes/{classe}/pericias")]
        public IActionResult ObterPericias(string classe)
        {
            var jsonPericias = Tormenta20Repository.ObterPericiasPorClasse(classe);

            if (jsonPericias == null)
            {
                return NotFound(new { mensagem = $"Perícias não encontradas para a classe '{classe}'." });
            }

            // Retorna a string direto como JSON (HTTP status 200 OK)
            return Content(jsonPericias, "application/json");
        }


        [HttpGet("talentos")]
        public IActionResult Talentos()
        {
            var jsonTalentos = Tormenta20Repository.Talentos();
            if (jsonTalentos == null) return NotFound(new { mensagem = "Arquivo de talentos não encontrado." });

            return Content(jsonTalentos, "application/json");
        }

        [HttpGet("talentos/{nome}")]
        public IActionResult ObterTalento(string nome)
        {
            var jsonTalento = Tormenta20Repository.ObterTalentoPorNome(nome);
            if (jsonTalento == null) return NotFound(new { mensagem = $"Talento '{nome}' não foi encontrado." });

            return Content(jsonTalento, "application/json");
        }
        
        [HttpGet("Origens")]
        public IActionResult Origens()
        {
            var jsonOrigens = Tormenta20Repository.Origens();
            if (jsonOrigens == null) return NotFound(new { mensagem = "Arquivo de origens não encontrado." });

            return Content(jsonOrigens, "application/json");
        }

        [HttpGet("Origens/{nome}")]
        public IActionResult ObterOrigem(string nome)
        {
            var jsonOrigem = Tormenta20Repository.ObterOrigensPorNome(nome);
            if (jsonOrigem == null) return NotFound(new { mensagem = $"Origem '{nome}' não foi encontrada." });

            return Content(jsonOrigem, "application/json");
        }

         [HttpGet("Magias")]
        public IActionResult Magias()
        {
            var jsonMagias = Tormenta20Repository.magias();
            if (jsonMagias == null) return NotFound(new { mensagem = "Arquivo de magias não encontrado." });

            return Content(jsonMagias, "application/json");

        }

         [HttpGet("Magias/{nome}")]
        public IActionResult ObterMagia(string nome)
        {
            var jsonMagia = Tormenta20Repository.ObterMagiasPorNome(nome);
            if (jsonMagia == null) return NotFound(new { mensagem = $"Magia '{nome}' não foi encontrada." });

            return Content(jsonMagia, "application/json");
        }

        [HttpGet("atributos")]
        public IActionResult ObterAtributos()
        {
            var jsonAtributos = Tormenta20Repository.atributos();
            if (jsonAtributos == null) return NotFound(new { mensagem = "Arquivo de atributos não encontrado." });

            return Content(jsonAtributos, "application/json");
        }


    }
}