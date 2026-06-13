using Microsoft.AspNetCore.Components;
using SvadbaWeb.Localization;

namespace SvadbaWeb.Components;

/// <summary>
/// Základ pre komponenty, ktoré zobrazujú lokalizovaný text. Automaticky sa
/// prekreslia pri zmene jazyka. V .razor použi <c>@inherits LocalizedComponentBase</c>
/// a texty čítaj cez <c>C.Nieco</c>.
/// </summary>
public abstract class LocalizedComponentBase : ComponentBase, IDisposable
{
    [Inject] protected LocalizationService Loc { get; set; } = default!;

    /// <summary>Aktuálne texty.</summary>
    protected SiteContent C => Loc.Content;

    protected override void OnInitialized() => Loc.OnChanged += HandleChanged;

    private void HandleChanged() => InvokeAsync(StateHasChanged);

    public virtual void Dispose() => Loc.OnChanged -= HandleChanged;
}
