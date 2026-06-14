using SvadbaWeb.Localization;

namespace SvadbaWeb.News;

/// <summary>
/// A single announcement loaded from <c>wwwroot/data/news.json</c>. Each item has a date
/// (YYYY-MM-DD format) and text in one or more languages. If a translation is missing,
/// a fallback is used (Sk → Cz → En). Adding announcements = editing the JSON file,
/// no need to change code or translate into every language.
/// </summary>
public class NewsItem
{
    public string Date { get; set; } = "";
    public NewsText? Sk { get; set; }
    public NewsText? Cz { get; set; }
    public NewsText? En { get; set; }

    /// <summary>Picks the text for the given language, with a sensible fallback if a translation is missing.</summary>
    public NewsText Localized(Language lang) => (lang switch
    {
        Language.Cz => Cz ?? Sk ?? En,
        Language.En => En ?? Sk ?? Cz,
        _ => Sk ?? Cz ?? En,
    }) ?? new NewsText();
}

public class NewsText
{
    public string Title { get; set; } = "";
    public string Text { get; set; } = "";
}
