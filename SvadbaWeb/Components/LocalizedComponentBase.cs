using Microsoft.AspNetCore.Components;
using SvadbaWeb.Localization;

namespace SvadbaWeb.Components;

/// <summary>
/// Base class for components that display localized text. They automatically
/// re-render when the language changes. In .razor use <c>@inherits LocalizedComponentBase</c>
/// and read texts via <c>C.Something</c>.
/// </summary>
public abstract class LocalizedComponentBase : ComponentBase, IDisposable
{
    [Inject] protected LocalizationService Loc { get; set; } = default!;

    /// <summary>The current texts.</summary>
    protected SiteContent C => Loc.Content;

    protected override void OnInitialized() => Loc.OnChanged += HandleChanged;

    private void HandleChanged() => InvokeAsync(StateHasChanged);

    public virtual void Dispose() => Loc.OnChanged -= HandleChanged;
}
