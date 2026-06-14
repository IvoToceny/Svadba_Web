namespace SvadbaWeb.Config;

/// <summary>
/// Central site settings. Change links, contact details and keys here.
/// (Page texts live in the Localization/ContentSk|Cz|En folder.)
/// </summary>
public static class SiteConfig
{
    // Google form link (RSVP questionnaire)
    public const string GoogleFormUrl = "https://forms.gle/tMXnmMwSWMaMJU6y6";

    // Mailbox that receives messages from the contact form
    public const string ContactEmail = "ivo6770@gmail.com";

    // ======================================================================
    //  FILL IN BEFORE GOING LIVE
    // ======================================================================

    // Free key from https://web3forms.com (register the ivo6770@gmail.com mail,
    // copy the "Access Key" and paste it here). Without it the contact form won't send mail.
    public const string Web3FormsAccessKey = "e882ec44-4345-4168-a73c-a69a26d873fa";

    // Phone number for the contact button (including country code)
    public const string PhoneNumber = "+420 606 089 487";

    // Messenger link (e.g. https://m.me/ivo.toceny)
    public const string MessengerUrl = "https://m.me/ivo.toceny";

    // ======================================================================

    // Venue website (the wedding location) — real link from the questionnaire
    public const string VenueSiteUrl = "https://svatbylysovice.cz/";

    // Venue map pin — real link from the questionnaire
    public const string VenueMapUrl = "https://maps.app.goo.gl/Ny3qKRMqfUNF355B6";

    // Accommodation search (Booking.com — Vyškov, wedding dates 25–27 Sep 2026 prefilled)
    public const string AccommodationUrl =
        "https://www.booking.com/searchresults.cs.html?ss=Vy%C5%A1kov&checkin=2026-09-25&checkout=2026-09-27&group_adults=2&no_rooms=1&group_children=0&dest_type=city";

    // Tip for a specific hotel (map)
    public const string HotelMapUrl =
        "https://www.google.com/maps/search/?api=1&query=Hotel+Allvet+Vy%C5%A1kov";

    // Colour palette inspiration
    public const string PalettePinterestUrl =
        "https://www.pinterest.com/search/pins/?q=burgundy%20rust%20olive%20autumn%20wedding%20guest%20outfit";
    public const string PaletteCoolorsUrl =
        "https://coolors.co/7f0021-9b3506-3f4632-5d6035-9e2c28-83512a";

    /// <summary>The wedding colour palette (shown on the site).</summary>
    public static readonly (string Hex, string Name)[] Palette =
    {
        ("#7F0021", "Burgundy"),
        ("#9B3506", "Rust"),
        ("#9E2C28", "Red"),
        ("#83512A", "Brown"),
        ("#5D6035", "Olive"),
        ("#3F4632", "Dark olive"),
    };

    /// <summary>True when a real Web3Forms key has been filled in.</summary>
    public static bool ContactFormConfigured =>
        !string.IsNullOrWhiteSpace(Web3FormsAccessKey) &&
        Web3FormsAccessKey != "YOUR-WEB3FORMS-ACCESS-KEY";

    public static string PhoneHref => "tel:" + PhoneNumber.Replace(" ", "");
}
