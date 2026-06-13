using SvadbaWeb.Localization;

namespace SvadbaWeb.News;

/// <summary>
/// Jedna aktualita načítaná z <c>wwwroot/data/news.json</c>. Každá položka má dátum
/// (formát YYYY-MM-DD) a text v jednom alebo viacerých jazykoch. Ak chýba preklad,
/// použije sa náhrada (Sk → Cz → En). Pridávanie aktualít = úprava JSON súboru,
/// netreba meniť kód ani prekladať do všetkých jazykov.
/// </summary>
public class NewsItem
{
    public string Date { get; set; } = "";
    public NewsText? Sk { get; set; }
    public NewsText? Cz { get; set; }
    public NewsText? En { get; set; }

    /// <summary>Vyberie text pre daný jazyk s rozumnou náhradou, ak preklad chýba.</summary>
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
