namespace SvadbaWeb.Config;

/// <summary>
/// Centrálne nastavenia stránky. Tu meň odkazy, kontakt a kľúče.
/// (Texty stránky sú v priečinku Localization/ContentSk|Cz|En.)
/// </summary>
public static class SiteConfig
{
    // Odkaz na Google formulár (RSVP dotazník)
    public const string GoogleFormUrl = "https://forms.gle/tMXnmMwSWMaMJU6y6";

    // Mail, na ktorý chodia správy z kontaktného formulára
    public const string ContactEmail = "ivo6770@gmail.com";

    // ======================================================================
    //  VYPLŇ PRED OSTRÝM NASADENÍM
    // ======================================================================

    // Bezplatný kľúč z https://web3forms.com (zaregistruj mail ivo6770@gmail.com,
    // skopíruj "Access Key" a vlož sem). Bez neho kontaktný formulár neodošle mail.
    public const string Web3FormsAccessKey = "YOUR-WEB3FORMS-ACCESS-KEY";

    // Telefónne číslo pre kontaktné tlačidlo (vrátane predvoľby)
    public const string PhoneNumber = "+421 900 000 000";

    // Odkaz na Messenger (napr. https://m.me/tvoje.meno)
    public const string MessengerUrl = "https://m.me/";

    // ======================================================================

    // Web areálu (miesto konania) — reálny odkaz z dotazníka
    public const string VenueSiteUrl = "https://svatbylysovice.cz/";

    // Mapa miesta konania — reálny pin z dotazníka
    public const string VenueMapUrl = "https://maps.app.goo.gl/Ny3qKRMqfUNF355B6";

    // Vyhľadávanie ubytovania (Booking.com — Vyškov, prednastavený termín svadby 25.–27. 9. 2026)
    public const string AccommodationUrl =
        "https://www.booking.com/searchresults.cs.html?ss=Vy%C5%A1kov&checkin=2026-09-25&checkout=2026-09-27&group_adults=2&no_rooms=1&group_children=0&dest_type=city";

    // Tip na konkrétny hotel (mapa)
    public const string HotelMapUrl =
        "https://www.google.com/maps/search/?api=1&query=Hotel+Allvet+Vy%C5%A1kov";

    /// <summary>Farebná paleta svadby (zobrazuje sa na stránke).</summary>
    public static readonly (string Hex, string Name)[] Palette =
    {
        ("#7F0021", "Burgundy"),
        ("#9B3506", "Rust"),
        ("#9E2C28", "Red"),
        ("#83512A", "Brown"),
        ("#5D6035", "Olive"),
        ("#3F4632", "Dark olive"),
    };

    /// <summary>True ak je doplnený reálny Web3Forms kľúč.</summary>
    public static bool ContactFormConfigured =>
        !string.IsNullOrWhiteSpace(Web3FormsAccessKey) &&
        Web3FormsAccessKey != "YOUR-WEB3FORMS-ACCESS-KEY";

    public static string PhoneHref => "tel:" + PhoneNumber.Replace(" ", "");
}
