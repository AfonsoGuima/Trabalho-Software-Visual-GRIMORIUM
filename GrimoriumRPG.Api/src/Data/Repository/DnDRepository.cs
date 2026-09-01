using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public static class DnDRepository
{
    private static readonly HttpClient _httpClient = new HttpClient();
    private const string BaseUrl = "https://www.dnd5eapi.co/api/2014/";

    public static async Task<string?> ObterTodosPorCategoriaAsync(string categoria)
    {
        string endpoint = NormalizarSlug(categoria);
        return await RealizarRequisicaoAsync(endpoint, endpoint);
    }

    public static async Task<string?> ObterPorCategoriaENomeAsync(string categoria, string nome)
    {
        string catSlug = NormalizarSlug(categoria);
        string itemSlug = NormalizarSlug(nome);
        return await RealizarRequisicaoAsync($"{catSlug}/{itemSlug}", catSlug);
    }

    private static async Task<string?> RealizarRequisicaoAsync(string endpoint, string chaveEnvelope)
    {
        try
        {
            string url = $"{BaseUrl}{endpoint}";
            string jsonResposta = await _httpClient.GetStringAsync(url);

            using (JsonDocument doc = JsonDocument.Parse(jsonResposta))
            {
                JsonElement root = doc.RootElement;
                return $"{{\"{chaveEnvelope}\": {root.GetRawText()}}}";
            }
        }
        catch (HttpRequestException)
        {
            return null;
        }
    }

    private static string NormalizarSlug(string texto)
    {
        return texto.Trim()
                    .ToLower()
                    .Replace(" ", "-")
                    .Replace("_", "-");
    }
}