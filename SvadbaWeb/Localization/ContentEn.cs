using SvadbaWeb.Config;

namespace SvadbaWeb.Localization;

/// <summary>English texts. Edit the English content here.</summary>
public static class ContentEn
{
    public static readonly SiteContent Value = new()
    {
        CoupleNames = "Denisa & Ivo",
        Date = "26 September 2026",
        VenueShort = "Lysovický rybník · Vyškov",
        Poem = "Among the whispering trees and the still water of the pond,\n" +
               "in the time when nature turns to gold,\n" +
               "we will promise each other love for a lifetime.\n" +
               "Come and share that moment with us.",
        Weekday = "Saturday",
        Month = "September",
        RsvpButton = "Fill out the form",

        InviteHeading = "Dear family, dear friends",
        InviteParagraphs = new[]
        {
            "With love and joy, we invite you to our wedding, which will take place on 26 September 2026 at Lysovický rybník near Vyškov.",
            "We would be delighted to see you all there and to share this special day with you. So that we can fine-tune everything down to the last detail and make you as comfortable as possible, we have put together the following information.",
        },

        InfoHeading = "Important information",
        InfoCards = new[]
        {
            new InfoItem("Ceremony",
                "The ceremony will take place on Saturday, 26 September 2026 at 1:00 p.m. If you plan to arrive on Saturday, please come by 12:00 p.m."),
            new InfoItem("Venue",
                "Lysovický rybník near Vyškov. We have the venue reserved from Friday until Sunday morning.",
                "Venue website", SiteConfig.VenueSiteUrl,
                "View on map", SiteConfig.VenueMapUrl),
            new InfoItem("Parking",
                "Parking is right at the venue and is free of charge."),
            new InfoItem("Accommodation",
                "We recommend accommodation in the town of Vyškov (~10 km from the venue). We've prepared a search for the wedding dates.",
                "Find a place (Booking.com)", SiteConfig.AccommodationUrl,
                "Hotel Allvet (our tip)", SiteConfig.HotelMapUrl),
            new InfoItem("Photos during the ceremony",
                "We kindly ask you to refrain from taking photos during the ceremony. Thank you."),
            new InfoItem("Programme",
                "We will share more details about the programme when the time is right."),
        },

        PaletteTitle = "Colour palette",
        PaletteText = "We would be delighted if your outfits followed our colour palette.",

        RsvpHeading = "Confirm your attendance",
        RsvpText = "So that we can fine-tune everything down to the last detail, we kindly ask you to fill out a short questionnaire. You will find questions about your attendance, food preferences and more.",
        RsvpDeadline = "Please send your answers ideally by 13 May 2026.",

        ContactHeading = "Have questions?",
        ContactText = "If you have any questions, write to us using the form below or contact us directly.",
        FormName = "Name",
        FormEmail = "Email",
        FormMessage = "Message",
        FormSend = "Send",
        FormSending = "Sending…",
        FormSuccess = "Thank you! Your message has been sent.",
        FormError = "Something went wrong. Please try again or contact us directly.",
        ContactOr = "or reach us directly",
        PhoneLabel = "Phone",
        MessengerLabel = "Messenger",

        NewsHeading = "Latest updates",

        MenuNavLabel = "Wedding menu",
        MenuHeading = "Wedding menu",
        MenuIntro = "For our big day we've prepared the following treats for you. Enjoy!",
        MenuCourses = new[]
        {
            new MenuCourse("Welcome refreshments", new[]
            {
                "Assorted decorated canapés",
                "Parma ham",
                "Selection of cheeses",
                "Pork crackling spread with bread",
            }),
            new MenuCourse("Starters & cold buffet", new[]
            {
                "Selection of Italian and French cheeses",
                "Pâté — venison, duck and chicken",
                "Beetroot carpaccio",
                "Beef tartare with toast and garlic",
            }),
            new MenuCourse("Soup", new[]
            {
                "Beef consommé with liver dumplings, noodles and vegetables",
            }),
            new MenuCourse("Main course", new[]
            {
                "Svíčková — beef sirloin in cream sauce with bread dumplings",
            }),
            new MenuCourse("Warm buffet", new[]
            {
                "Schnitzels — chicken, pork and venison",
                "Beef and venison goulash",
                "Grilled camembert with buttered vegetables",
                "Mini burgers",
                "Citrus-marinated salmon",
            }),
            new MenuCourse("Salads", new[]
            {
                "Pasta salad",
                "Greek salad",
                "Mixed leaf salad with dressing and parmesan",
            }),
            new MenuCourse("Sides", new[]
            {
                "Grilled vegetables",
                "Roast potatoes with herbs and garlic",
                "Fries",
                "Ratatouille",
                "Bread selection",
            }),
        },
        MenuDietaryNote = "On request we'll prepare a vegetarian variant — meat replaced with halloumi, soft cheese or tofu. We'll also accommodate other dietary needs, just let us know.",
        MenuBackLabel = "Back to home",

        FooterSignature = "With love, Deni & Ivo",
    };
}
