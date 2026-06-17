namespace SvadbaWeb.Localization;

/// <summary>One info card (title + text, optionally up to two links).</summary>
public record InfoItem(
    string Title,
    string Text,
    string? LinkLabel = null,
    string? LinkUrl = null,
    string? Link2Label = null,
    string? Link2Url = null);

/// <summary>One wedding-menu course (heading + list of dishes).</summary>
public record MenuCourse(string Title, string[] Items);

/// <summary>One programme entry (time + description).</summary>
public record ProgramEntry(string Time, string Text);

/// <summary>One programme day (day heading + entries).</summary>
public record ProgramDay(string Title, ProgramEntry[] Entries);

/// <summary>
/// All page texts for a single language. The actual translations live in
/// ContentSk.cs / ContentCz.cs / ContentEn.cs — edit the texts there.
/// </summary>
public record SiteContent
{
    // ----- Hero -----
    public required string CoupleNames { get; init; }
    public required string Date { get; init; }
    public required string VenueShort { get; init; }
    public required string Poem { get; init; }      // poem from the invitation (lines separated by \n)
    public required string Weekday { get; init; }    // e.g. Saturday
    public required string Month { get; init; }      // e.g. September / Září
    public required string RsvpButton { get; init; }

    // ----- Wedding countdown (on the home page) -----
    public required string CountdownDays { get; init; }
    public required string CountdownHours { get; init; }
    public required string CountdownMinutes { get; init; }
    public required string CountdownSeconds { get; init; }
    public required string CountdownDone { get; init; }

    // ----- Invitation -----
    public required string InviteHeading { get; init; }
    public required string[] InviteParagraphs { get; init; }

    // ----- Information -----
    public required string InfoHeading { get; init; }
    public required InfoItem[] InfoCards { get; init; }

    // ----- Colour palette (/paleta page) -----
    public required string PaletteTitle { get; init; }
    public required string PaletteText { get; init; }
    public required string PaletteInspoHeading { get; init; }
    public required string PaletteInspoText { get; init; }
    public required string PalettePinterestLabel { get; init; }
    public required string PaletteCoolorsLabel { get; init; }

    // ----- RSVP -----
    public required string RsvpHeading { get; init; }
    public required string RsvpText { get; init; }
    public required string RsvpDeadline { get; init; }

    // ----- Contact -----
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

    // ----- Navigation (top nav bar) -----
    public required string NavHome { get; init; }
    public required string NavNews { get; init; }
    public required string NavPalette { get; init; }
    // (the programme link uses ProgramHeading, the menu link uses MenuNavLabel)

    // ----- News / Announcements (/aktuality page) -----
    public required string NewsHeading { get; init; }
    public required string NewsEmpty { get; init; }   // text shown when there are no announcements

    // ----- Programme (/program page) -----
    public required string ProgramHeading { get; init; }
    public required string ProgramIntro { get; init; }
    public required ProgramDay[] ProgramDays { get; init; }
    public required string ProgramNote { get; init; }

    // ----- Wedding menu (/menu page) -----
    public required string MenuNavLabel { get; init; }   // text of the menu tab/link
    public required string MenuHeading { get; init; }
    public required string MenuIntro { get; init; }
    public required MenuCourse[] MenuCourses { get; init; }
    public required string MenuDietaryNote { get; init; }
    public required string MenuComingSoon { get; init; }   // shown while the menu is temporarily hidden

    // ----- Footer -----
    public required string FooterSignature { get; init; }
}
