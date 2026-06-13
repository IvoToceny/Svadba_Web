namespace SvadbaWeb.Localization;

/// <summary>Jedna informačná kartička (nadpis + text, voliteľne až dva odkazy).</summary>
public record InfoItem(
    string Title,
    string Text,
    string? LinkLabel = null,
    string? LinkUrl = null,
    string? Link2Label = null,
    string? Link2Url = null);

/// <summary>Jeden chod svadobného menu (nadpis + zoznam jedál).</summary>
public record MenuCourse(string Title, string[] Items);

/// <summary>Jedna položka programu (čas + popis).</summary>
public record ProgramEntry(string Time, string Text);

/// <summary>Jeden deň programu (nadpis dňa + položky).</summary>
public record ProgramDay(string Title, ProgramEntry[] Entries);

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

    // ----- Navigácia (top nav bar) -----
    public required string NavHome { get; init; }
    public required string NavNews { get; init; }
    // (odkaz na program používa ProgramHeading, odkaz na menu používa MenuNavLabel)

    // ----- Aktuality / Oznámenia (stránka /aktuality) -----
    public required string NewsHeading { get; init; }
    public required string NewsEmpty { get; init; }   // text, keď nie sú žiadne aktuality

    // ----- Program (stránka /program) -----
    public required string ProgramHeading { get; init; }
    public required string ProgramIntro { get; init; }
    public required ProgramDay[] ProgramDays { get; init; }
    public required string ProgramNote { get; init; }

    // ----- Svadobné menu (stránka /menu) -----
    public required string MenuNavLabel { get; init; }   // text tabu/odkazu na menu
    public required string MenuHeading { get; init; }
    public required string MenuIntro { get; init; }
    public required MenuCourse[] MenuCourses { get; init; }
    public required string MenuDietaryNote { get; init; }

    // ----- Pätička -----
    public required string FooterSignature { get; init; }
}
