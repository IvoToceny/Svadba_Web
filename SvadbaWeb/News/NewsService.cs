using System.Net.Http.Json;
using System.Text.Json;

namespace SvadbaWeb.News;

/// <summary>
/// Načíta aktuality zo statického súboru <c>wwwroot/data/news.json</c> a zoradí ich
/// od najnovšej. Súbor je editovateľný bez prekladu (aj priamo na GitHube), zmena sa
/// prejaví po nasadení. Ak súbor chýba alebo je prázdny, sekcia aktualít sa nezobrazí.
/// </summary>
public class NewsService
{
    private static readonly JsonSerializerOptions JsonOptions = new(JsonSerializerDefaults.Web);

    private readonly HttpClient _http;
    private IReadOnlyList<NewsItem>? _cache;

    public NewsService(HttpClient http) => _http = http;

    public async Task<IReadOnlyList<NewsItem>> GetAllAsync()
    {
        if (_cache is not null) return _cache;

        try
        {
            var items = await _http.GetFromJsonAsync<List<NewsItem>>("data/news.json", JsonOptions);
            _cache = (items ?? new List<NewsItem>())
                .Where(i => !string.IsNullOrWhiteSpace(i.Date))
                .OrderByDescending(i => i.Date, StringComparer.Ordinal) // ISO dátumy → poradie = chronologické
                .ToList();
        }
        catch
        {
            // Súbor nemusí existovať (alebo je neplatný) — aktuality jednoducho nebudú.
            _cache = new List<NewsItem>();
        }

        return _cache;
    }
}
