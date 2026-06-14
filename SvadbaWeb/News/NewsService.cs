using System.Net.Http.Json;
using System.Text.Json;

namespace SvadbaWeb.News;

/// <summary>
/// Loads announcements from the static <c>wwwroot/data/news.json</c> file and sorts them
/// newest-first. The file can be edited without recompiling (even directly on GitHub); the
/// change takes effect after deployment. If the file is missing or empty, the news section is hidden.
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
                .OrderByDescending(i => i.Date, StringComparer.Ordinal) // ISO dates → ordering = chronological
                .ToList();
        }
        catch
        {
            // The file may not exist (or may be invalid) — just show no announcements.
            _cache = new List<NewsItem>();
        }

        return _cache;
    }
}
