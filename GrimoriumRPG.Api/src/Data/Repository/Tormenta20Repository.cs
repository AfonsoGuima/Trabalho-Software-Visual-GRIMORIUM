using System.IO;
using System.Text.Json;

namespace GrimoriumRPG.Api.Data.Repositories
{
    public static class Tormenta20Repository
    {
        private static string ObterCaminhoJson(string nomeArquivo)
        {
            return Path.Combine(Directory.GetCurrentDirectory(), "src", "Data", "jsonTormenta20", nomeArquivo);
        }

        public static string? ObterTodasDivindades()
        {
            string caminho = ObterCaminhoJson("divindades.json");
            if (!File.Exists(caminho)) return null;

            return File.ReadAllText(caminho);
        }

        public static string? ObterDivindadePorNome(string nome)
        {
            string caminho = ObterCaminhoJson("divindades.json");
            if (!File.Exists(caminho)) return null;

            var jsonTexto = File.ReadAllText(caminho);
            var divindades = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(jsonTexto);

            var chaveEncontrada = divindades?.Keys.FirstOrDefault(k => k.Equals(nome, StringComparison.OrdinalIgnoreCase));

            return chaveEncontrada != null ? divindades![chaveEncontrada].GetRawText() : null;
        }

        public static string? Habilidades()
        {
            string caminho = ObterCaminhoJson("habilidades.json");
            if (!File.Exists(caminho)) return null;

            return File.ReadAllText(caminho);


        }

         public static string? ObterHabilidadePorNome(string nome)
        {
            var jsonText = Habilidades(); 
            if (string.IsNullOrEmpty(jsonText)) return null;

            
            string chaveBusca = nome.Trim()
                                .ToLower()
                                .Replace(" ", "_")
                                .Replace("-", "_");

            using (JsonDocument doc = JsonDocument.Parse(jsonText))
            {
                JsonElement root = doc.RootElement;

                if (root.TryGetProperty(chaveBusca, out JsonElement habilidadeElement))
                {
                    return $"{{\"habilidade\": {habilidadeElement.GetRawText()}}}";
                }

                foreach (JsonProperty item in root.EnumerateObject())
                {
                    if (item.Value.TryGetProperty("nome", out JsonElement nomeProp))
                    {
                        if (string.Equals(nomeProp.GetString(), nome, StringComparison.OrdinalIgnoreCase))
                        {
                            return $"{{\"habilidade\": {item.Value.GetRawText()}}}";
                        }
                    }
                }
            }

            return null; 
        }
    

        public static string? Racas()
        {
            string caminho = ObterCaminhoJson("racas.json");
            if (!File.Exists(caminho)) return null;

            return File.ReadAllText(caminho);
        }

        public static string? ObterRacaPorNome(string nome)
        {
            var jsonText = Racas();
            if (string.IsNullOrEmpty(jsonText)) return null;

            string chaveBusca = nome.Trim()
                            .ToLower()
                            .Replace(" ", "_")
                            .Replace("-", "_");

            using (JsonDocument doc = JsonDocument.Parse(jsonText))
            {
            JsonElement root = doc.RootElement;

            if (root.TryGetProperty(chaveBusca, out JsonElement racaElement))
            {
                return $"{{\"raca\": {racaElement.GetRawText()}}}";
            }

            foreach (JsonProperty item in root.EnumerateObject())
            {
                if (item.Value.TryGetProperty("nome", out JsonElement nomeProp))
                {
                    if (string.Equals(nomeProp.GetString(), nome, StringComparison.OrdinalIgnoreCase))
                    {
                        return $"{{\"raca\": {item.Value.GetRawText()}}}";
                    }
                }
             }
            }

            return null;
        }

        public static string? pericias()
        {
            string caminho = ObterCaminhoJson("pericias.json");
            if (!File.Exists(caminho)) return null;

            return File.ReadAllText(caminho);
        }

        public static string? ObterPericiaPorNome(string nome)
        {
            string caminho = ObterCaminhoJson("pericias.json");
            if (!File.Exists(caminho)) return null;

            var jsonTexto = File.ReadAllText(caminho);
            var pericias = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(jsonTexto);

            var chaveEncontrada = pericias?.Keys.FirstOrDefault(k => k.Equals(nome, StringComparison.OrdinalIgnoreCase));

            return chaveEncontrada != null ? pericias![chaveEncontrada].GetRawText() : null;
        }

        public static string? classes()
        {
            string caminho = ObterCaminhoJson("classes.json");
            if (!File.Exists(caminho)) return null;

            return File.ReadAllText(caminho);
        }

        public static string? ObterClassePorNome(string nome)
        {
            string caminho = ObterCaminhoJson("classes.json");
            if (!File.Exists(caminho)) return null;

            var jsonTexto = File.ReadAllText(caminho);
            var classes = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(jsonTexto);

            var chaveEncontrada = classes?.Keys.FirstOrDefault(k => k.Equals(nome, StringComparison.OrdinalIgnoreCase));

            return chaveEncontrada != null ? classes![chaveEncontrada].GetRawText() : null;
        }

        public static string? ObterHabilidadesPorClasse(string nome, string habilidade)
        {

            var jsonText = ObterClassePorNome(nome);
            if (string.IsNullOrEmpty(jsonText)) return null;

            
            using (JsonDocument doc = JsonDocument.Parse(jsonText))
            {
                JsonElement root = doc.RootElement;

                
                if (root.TryGetProperty(nome.ToLower(), out JsonElement classeElement))
                {
                    root = classeElement;
                }

                
                if (!root.TryGetProperty("habilidades", out JsonElement habilidadesElement) || 
                    habilidadesElement.ValueKind != JsonValueKind.Object)
                {
                    return null;
                }

               
                foreach (JsonProperty item in habilidadesElement.EnumerateObject())
                {
                    JsonElement habAtual = item.Value;
                    
                    if (habAtual.TryGetProperty("nome", out JsonElement nomeElement))
                    {
                        string? nomeNoJson = nomeElement.GetString();

                        if (string.Equals(nomeNoJson, habilidade, StringComparison.OrdinalIgnoreCase))
                        {
                            
                            return habAtual.GetRawText();
                        }
                    }
                }
                return null;
            }
        }


         public static string? ObterTabelaNivelPorClasse(string nome)
        {
                var jsonText = ObterClassePorNome(nome);
                if (string.IsNullOrEmpty(jsonText)) return null;

                using (JsonDocument doc = JsonDocument.Parse(jsonText))
                {
                    JsonElement root = doc.RootElement;

                    if (root.TryGetProperty(nome.ToLower(), out JsonElement classeElement))
                    {
                        root = classeElement;
                    }

                    if (root.TryGetProperty("tabela", out JsonElement tabelaElement))
                    {
                        
                        string tabelaJson = tabelaElement.GetRawText();
                        return $"{{\"tabela\": {tabelaJson}}}";
                    }
                }

                return null;
        }
        public static string? ObterProeficienciasPorClasse(string nome)
        {
            
            var jsonText = ObterClassePorNome(nome);
            if (string.IsNullOrEmpty(jsonText)) return null;

            
            using (JsonDocument doc = JsonDocument.Parse(jsonText))
            {
                JsonElement root = doc.RootElement;

                
                if (root.TryGetProperty(nome.ToLower(), out JsonElement classeElement))
                {
                    root = classeElement;
                }

               
                if (root.TryGetProperty("proeficiencias", out JsonElement proefElement))
                {
                    
                    string proefJson = proefElement.GetRawText();

                    
                    return $"{{\"proeficiencias\": {proefJson}}}";
                }
            }

            return null; 
        }

        public static string? ObterPericiasPorClasse(string nome)
        {
           
            var jsonText = ObterClassePorNome(nome);
            if (string.IsNullOrEmpty(jsonText)) return null;

       
            using (JsonDocument doc = JsonDocument.Parse(jsonText))
            {
                JsonElement root = doc.RootElement;

                
                if (root.TryGetProperty(nome.ToLower(), out JsonElement classeElement))
                {
                    root = classeElement;
                }

                if (root.TryGetProperty("pericias", out JsonElement periciasElement))
                {
                    string periciasJson = periciasElement.GetRawText();

                    return $"{{\"pericias\": {periciasJson}}}";
                }
            }

            return null; 
        }

        public static string? Talentos()
        {
            string caminho = ObterCaminhoJson("talentos.json");
            if (!File.Exists(caminho)) return null;

            return File.ReadAllText(caminho);
            
        }

        public static string? ObterTalentoPorNome(string nomeTalento)
        {
        
        var jsonText = Talentos();
        if (string.IsNullOrEmpty(jsonText)) return null;

        
        string chaveBusca = nomeTalento.Trim()
                                      .ToLower()
                                      .Replace(" ", "_")
                                      .Replace("-", "_");
        
        using (JsonDocument doc = JsonDocument.Parse(jsonText))
        {
            JsonElement root = doc.RootElement;
            
            if (root.TryGetProperty(chaveBusca, out JsonElement talentoElement))
            {
                return $"{{\"talento\": {talentoElement.GetRawText()}}}";
            }

            foreach (JsonProperty item in root.EnumerateObject())
            {
                if (item.Value.TryGetProperty("nome", out JsonElement nomeProp))
                {
                    if (string.Equals(nomeProp.GetString(), nomeTalento, StringComparison.OrdinalIgnoreCase))
                    {
                        return $"{{\"talento\": {item.Value.GetRawText()}}}";
                    }
                }
            }
            }

            return null; 
         }
        
        public static string? Origens()
        {
            
            string caminho = ObterCaminhoJson("origens.json");
            if (!File.Exists(caminho)) return null;

            return File.ReadAllText(caminho);

        }

        public static string? ObterOrigensPorNome(string nome)
    {
        
        var jsonText = Origens();
        if (string.IsNullOrEmpty(jsonText)) return null;

        
        string chaveBusca = nome.Trim()
                               .ToLower()
                               .Replace(" ", "_")
                               .Replace("-", "_");

        using (JsonDocument doc = JsonDocument.Parse(jsonText))
        {
            JsonElement root = doc.RootElement;

            
            if (root.TryGetProperty(chaveBusca, out JsonElement origemElement))
            {
                return $"{{\"origem\": {origemElement.GetRawText()}}}";
            }

            
            foreach (JsonProperty item in root.EnumerateObject())
            {
                if (item.Value.TryGetProperty("nome", out JsonElement nomeProp))
                {
                    if (string.Equals(nomeProp.GetString(), nome, StringComparison.OrdinalIgnoreCase))
                    {
                        return $"{{\"origem\": {item.Value.GetRawText()}}}";
                    }
                }
            }
        }

        return null; 
    }

    public static string? magias()
    {
        string caminho = ObterCaminhoJson("magias.json");
        if (!File.Exists(caminho)) return null;

        return File.ReadAllText(caminho);
      
    }

    public static string? ObterMagiasPorNome(string nome)
    {
    
        var jsonText = magias();
        if (string.IsNullOrEmpty(jsonText)) return null;

    
        string chaveBusca = nome.Trim()
                           .ToLower()
                           .Replace(" ", "_")
                           .Replace("-", "_");

        using (JsonDocument doc = JsonDocument.Parse(jsonText))
        {
            JsonElement root = doc.RootElement;

        
            if (root.TryGetProperty(chaveBusca, out JsonElement magiaElement))
            {
                return $"{{\"magia\": {magiaElement.GetRawText()}}}";
            }

            
            foreach (JsonProperty item in root.EnumerateObject())
            {
                if (item.Value.TryGetProperty("nome", out JsonElement nomeProp))
                {
                    if (string.Equals(nomeProp.GetString(), nome, StringComparison.OrdinalIgnoreCase))
                    {
                        return $"{{\"magia\": {item.Value.GetRawText()}}}";
                    }
                }
            }
        }

        return null; 
    }   


    public static string? atributos()
    {
        string caminho = ObterCaminhoJson("atributos.json");
        if (!File.Exists(caminho)) return null;

        return File.ReadAllText(caminho);
    }









    }
}