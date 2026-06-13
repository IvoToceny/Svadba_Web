using Microsoft.JSInterop;

namespace SvadbaWeb.Localization;

/// <summary>
/// Drží aktuálny jazyk a príslušné texty. Voľbu jazyka ukladá do localStorage,
/// takže ostane zapamätaná aj po obnovení stránky. Pri zmene jazyka vyvolá
/// <see cref="OnChanged"/>, na čo komponenty zareagujú prekreslením.
/// </summary>
public class LocalizationService
{
    private const string StorageKey = "svadba.lang";
    private readonly IJSRuntime _js;

    public LocalizationService(IJSRuntime js) => _js = js;

    public Language CurrentLanguage { get; private set; } = Language.Sk;

    public SiteContent Content { get; private set; } = ContentSk.Value;

    public event Action? OnChanged;

    /// <summary>Načíta uložený jazyk (ak existuje). Volá sa raz pri štarte.</summary>
    public async Task InitializeAsync()
    {
        try
        {
            var stored = await _js.InvokeAsync<string?>("localStorage.getItem", StorageKey);
            if (Enum.TryParse<Language>(stored, ignoreCase: true, out var lang) && lang != CurrentLanguage)
            {
                Apply(lang);
                await SetHtmlLangAsync();
            }
        }
        catch
        {
            // localStorage nemusí byť dostupné (napr. súkromné okno) — ostane default Sk.
        }
    }

    public async Task SetLanguageAsync(Language lang)
    {
        if (lang == CurrentLanguage) return;
        Apply(lang);
        try
        {
            await _js.InvokeVoidAsync("localStorage.setItem", StorageKey, lang.ToString());
            await SetHtmlLangAsync();
        }
        catch { /* ignore */ }
    }

    private void Apply(Language lang)
    {
        CurrentLanguage = lang;
        Content = lang switch
        {
            Language.Cz => ContentCz.Value,
            Language.En => ContentEn.Value,
            _ => ContentSk.Value,
        };
        OnChanged?.Invoke();
    }

    private async Task SetHtmlLangAsync()
    {
        var code = CurrentLanguage switch
        {
            Language.Cz => "cs",
            Language.En => "en",
            _ => "sk",
        };
        await _js.InvokeVoidAsync("document.documentElement.setAttribute", "lang", code);
    }
}
