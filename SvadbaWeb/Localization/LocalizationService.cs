using Microsoft.JSInterop;

namespace SvadbaWeb.Localization;

/// <summary>
/// Holds the current language and its texts. The language choice is stored in
/// localStorage, so it is remembered after a page reload. When the language
/// changes it raises <see cref="OnChanged"/>, which components react to by re-rendering.
/// </summary>
public class LocalizationService
{
    private const string StorageKey = "svadba.lang";
    private readonly IJSRuntime _js;

    public LocalizationService(IJSRuntime js) => _js = js;

    public Language CurrentLanguage { get; private set; } = Language.Sk;

    public SiteContent Content { get; private set; } = ContentSk.Value;

    public event Action? OnChanged;

    /// <summary>Loads the stored language (if any). Called once at startup.</summary>
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
            // localStorage may be unavailable (e.g. a private window) — the default Sk stays.
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
