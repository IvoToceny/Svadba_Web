using SvadbaWeb.Config;

namespace SvadbaWeb.Localization;

/// <summary>Slovenské texty stránky. Tu meň slovenský obsah.</summary>
public static class ContentSk
{
    public static readonly SiteContent Value = new()
    {
        CoupleNames = "Denisa & Ivo",
        Date = "26. septembra 2026",
        VenueShort = "Lysovický rybník · Vyškov",
        Poem = "Medzi šumením stromov a hladinou rybníka,\n" +
               "v čase, keď sa príroda farbí do zlata,\n" +
               "si sľúbime lásku na celý život.\n" +
               "Príďte ten okamih zdieľať s nami.",
        Weekday = "Sobota",
        Month = "September",
        RsvpButton = "Vyplniť dotazník",

        InviteHeading = "Milá rodina, drahí priatelia",
        InviteParagraphs = new[]
        {
            "S láskou a radosťou vás pozývame na našu svadbu, ktorá sa uskutoční 26. septembra 2026 na Lysovickom rybníku neďaleko Vyškova.",
            "Veľmi nás poteší, ak sa tam všetci uvidíme a budeme môcť tento výnimočný deň zdieľať spolu s vami. Aby sme všetko doladili do posledného detailu a zabezpečili čo najväčšie pohodlie, pripravili sme pre vás nasledujúce informácie.",
        },

        InfoHeading = "Dôležité informácie",
        InfoCards = new[]
        {
            new InfoItem("Obrad",
                "Obrad sa bude konať v sobotu 26. 9. 2026 o 13:00. Ak plánujete prísť až v sobotu, prosíme, dostavte sa do 12:00."),
            new InfoItem("Miesto",
                "Lysovický rybník neďaleko Vyškova. Areál máme rezervovaný od piatku do nedele rána.",
                "Stránka areálu", SiteConfig.VenueSiteUrl,
                "Zobraziť na mape", SiteConfig.VenueMapUrl),
            new InfoItem("Parkovanie",
                "Parkovanie je priamo v areáli a je bezplatné."),
            new InfoItem("Ubytovanie",
                "Ubytovanie odporúčame v meste Vyškov (~10 km od miesta konania). Pripravili sme pre vás vyhľadávanie ubytovania na termín svadby.",
                "Nájsť ubytovanie (Booking.com)", SiteConfig.AccommodationUrl,
                "Hotel Allvet (náš tip)", SiteConfig.HotelMapUrl),
            new InfoItem("Fotenie počas obradu",
                "Prosíme vás o láskavé zdržanie sa fotenia počas obradu. Ďakujeme."),
            new InfoItem("Program",
                "Bližšie informácie k programu vám prinesieme, keď príde ten správny čas."),
        },

        PaletteTitle = "Farebná paleta",
        PaletteText = "Budeme veľmi radi, ak svojím oblečením podporíte našu farebnú paletu.",

        RsvpHeading = "Potvrďte svoju účasť",
        RsvpText = "Aby sme mohli všetko doladiť do posledného detailu, prosíme vás o vyplnenie krátkeho dotazníka. Nájdete v ňom otázky o vašej účasti, preferenciách v jedle a ďalšie.",
        RsvpDeadline = "Odpovede prosíme zaslať ideálne do 13. 5. 2026.",

        ContactHeading = "Máte otázky?",
        ContactText = "Ak máte akékoľvek otázky, napíšte nám cez formulár nižšie alebo nás kontaktujte priamo.",
        FormName = "Meno",
        FormEmail = "E-mail",
        FormMessage = "Správa",
        FormSend = "Odoslať",
        FormSending = "Odosielam…",
        FormSuccess = "Ďakujeme! Vaša správa bola odoslaná.",
        FormError = "Niečo sa pokazilo. Skúste to prosím znova alebo nás kontaktujte priamo.",
        ContactOr = "alebo nás kontaktujte priamo",
        PhoneLabel = "Telefón",
        MessengerLabel = "Messenger",

        NavHome = "Domov",
        NavNews = "Aktuality",

        NewsHeading = "Aktuality",
        NewsEmpty = "Zatiaľ tu nie sú žiadne aktuality. Čoskoro sem pridáme novinky.",

        ProgramHeading = "Program",
        ProgramIntro = "Ako bude prebiehať náš svadobný víkend. Časy ešte spresníme.",
        ProgramDays = new[]
        {
            new ProgramDay("Piatok 25. 9.", new[]
            {
                new ProgramEntry("Večer", "Večerné posedenie"),
            }),
            new ProgramDay("Sobota 26. 9. — svadobný deň", new[]
            {
                new ProgramEntry("do 12:00", "Príchod hostí najneskôr o 12:00"),
                new ProgramEntry("13:00", "Obrad"),
                new ProgramEntry("14:00", "Novomanželské fotenie a program pre hostí"),
                new ProgramEntry("15:30", "Slávnostné jedlo"),
            }),
            new ProgramDay("Nedeľa 27. 9.", new[]
            {
                new ProgramEntry("9:00", "Rozlúčka a odchod"),
            }),
        },
        ProgramNote = "Zvyšok programu ešte doladíme — podrobnosti čoskoro doplníme.",

        MenuNavLabel = "Svadobné menu",
        MenuHeading = "Svadobné menu",
        MenuIntro = "Na náš veľký deň sme pre vás pripravili nasledujúce dobroty. Dobrú chuť!",
        MenuCourses = new[]
        {
            new MenuCourse("Uvítacie občerstvenie", new[]
            {
                "Zdobené kanapky (rôzne druhy)",
                "Parmská šunka",
                "Výber syrov",
                "Škvarková nátierka s chlebom",
            }),
            new MenuCourse("Predkrmy a studený raut", new[]
            {
                "Výber talianskych a francúzskych syrov",
                "Paštéta — zverinová, kačacia a kuracia",
                "Carpaccio z cvikly",
                "Hovädzí tatarák s hriankami a cesnakom",
            }),
            new MenuCourse("Polievka", new[]
            {
                "Hovädzí vývar s pečeňovými knedlíčkami, rezancami a zeleninou",
            }),
            new MenuCourse("Hlavný chod", new[]
            {
                "Sviečková na smotane s knedľou",
            }),
            new MenuCourse("Teplý raut", new[]
            {
                "Rezne — kuracie, bravčové a zo zveriny",
                "Hovädzí a zverinový guláš",
                "Grilovaný hermelín s maslovou zeleninou",
                "Mini burgery",
                "Losos marinovaný v citrusoch",
            }),
            new MenuCourse("Šaláty", new[]
            {
                "Cestovinový šalát",
                "Grécky šalát",
                "Mix listových šalátov s dresingom a parmezánom",
            }),
            new MenuCourse("Prílohy", new[]
            {
                "Grilovaná zelenina",
                "Pečené zemiaky s bylinkami a cesnakom",
                "Hranolky",
                "Ratatouille",
                "Výber pečiva",
            }),
        },
        MenuDietaryNote = "Na želanie pripravíme aj vegetariánsku variantu — mäso nahradíme syrom halloumi, hermelínom alebo tofu. Zohľadníme aj ďalšie diétne obmedzenia, stačí nám dať vedieť.",

        FooterSignature = "S láskou, Deni & Ivo",
    };
}
