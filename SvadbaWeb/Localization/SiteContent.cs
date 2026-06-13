namespace SvadbaWeb.Localization;

/// <summary>Jedna informačná kartička (nadpis + text, voliteľne odkaz).</summary>
public record InfoItem(string Title, string Text, string? LinkLabel = null, string? LinkUrl = null);

/// <summary>
/// Všetky texty stránky pre jeden jazyk. Konkrétne preklady sú v
/// ContentSk.cs / ContentCz.cs / ContentEn.cs — tam meň texty.
/// </summary>
public record SiteContent
{
    // ----- Hero -----
    public required string CoupleNames { get; init; }
    public required string Date { get; init; }
    public required string VenueShort { get; init; }
    public required string Poem { get; init; }      // báseň z pozvánky (riadky oddelené \n)
    public required string Weekday { get; init; }    // napr. Sobota
    public required string Month { get; init; }      // napr. September / Září
    public required string RsvpButton { get; init; }

    // ----- Pozvanie -----
    public required string InviteHeading { get; init; }
    public required string[] InviteParagraphs { get; init; }

    // ----- Informácie -----
    public required string InfoHeading { get; init; }
    public required InfoItem[] InfoCards { get; init; }

    // ----- Farebná paleta -----
    public required string PaletteTitle { get; init; }
    public required string PaletteText { get; init; }

    // ----- RSVP -----
    public required string RsvpHeading { get; init; }
    public required string RsvpText { get; init; }
    public required string RsvpDeadline { get; init; }

    // ----- Kontakt -----
    public required string ContactHeading { get; init; }
    public required string ContactText { get; init; }
    public required string FormName { get; init; }
    public required string FormEmail { get; init; }
    public required string FormMessage { get; init; }
    public required string FormSend { get; init; }
    public required string FormSending { get; init; }
    public required string FormSuccess { get; init; }
    public required string FormError { get; init; }
    public required string ContactOr { get; init; }
    public required string PhoneLabel { get; init; }
    public required string MessengerLabel { get; init; }

    // ----- Pätička -----
    public required string FooterSignature { get; init; }
}
