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
                "View on map", SiteConfig.VenueMapUrl),
            new InfoItem("Parking",
                "Parking is right at the venue and is free of charge."),
            new InfoItem("Accommodation",
                "We recommend accommodation in the town of Vyškov (~10 km from the venue). Our tip is hotel Allvet.",
                "Hotel Allvet", SiteConfig.HotelMapUrl),
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

        FooterSignature = "With love, Deni & Ivo",
    };
}
