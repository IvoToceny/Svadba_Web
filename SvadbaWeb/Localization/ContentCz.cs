using SvadbaWeb.Config;

namespace SvadbaWeb.Localization;

/// <summary>České texty stránky. Tu měň český obsah.</summary>
public static class ContentCz
{
    public static readonly SiteContent Value = new()
    {
        CoupleNames = "Denisa & Ivo",
        Date = "26. září 2026",
        VenueShort = "Lysovický rybník · Vyškov",
        Poem = "Mezi šuměním stromů a hladinou rybníka,\n" +
               "v čase, kdy se příroda barví do zlata,\n" +
               "si slíbíme lásku na celý život.\n" +
               "Přijďte ten okamžik sdílet s námi.",
        Weekday = "Sobota",
        Month = "Září",
        RsvpButton = "Vyplnit dotazník",

        CountdownDays = "dní",
        CountdownHours = "hodin",
        CountdownMinutes = "minut",
        CountdownSeconds = "sekund",
        CountdownDone = "Velký den je tu! 💍",

        InviteHeading = "Milá rodino, drazí přátelé",
        InviteParagraphs = new[]
        {
            "S láskou a radostí vás zveme na naši svatbu, která se uskuteční 26. září 2026 na Lysovickém rybníku nedaleko Vyškova.",
            "Velmi nás potěší, pokud se tam všichni uvidíme a budeme moci tento výjimečný den sdílet společně s vámi. Abychom vše doladili do posledního detailu a zajistili co největší pohodlí, připravili jsme pro vás následující informace.",
        },

        InfoHeading = "Důležité informace",
        InfoCards = new[]
        {
            new InfoItem("Obřad",
                "Obřad se bude konat v sobotu 26. 9. 2026 ve 13:00. Pokud plánujete přijet až v sobotu, prosíme, dostavte se do 12:00."),
            new InfoItem("Místo",
                "Lysovický rybník nedaleko Vyškova. Areál máme rezervovaný od pátku do nedělního rána.",
                "Stránka areálu", SiteConfig.VenueSiteUrl,
                "Zobrazit na mapě", SiteConfig.VenueMapUrl),
            new InfoItem("Parkování",
                "Parkování je přímo v areálu a je zdarma."),
            new InfoItem("Ubytování",
                "Ubytování doporučujeme ve městě Vyškov (~10 km od místa konání). Připravili jsme pro vás vyhledávání ubytování na termín svatby.",
                "Najít ubytování (Booking.com)", SiteConfig.AccommodationUrl,
                "Hotel Allvet (náš tip)", SiteConfig.HotelMapUrl),
            new InfoItem("Focení během obřadu",
                "Prosíme vás o laskavé zdržení se focení během obřadu. Děkujeme."),
        },

        PaletteTitle = "Barevná paleta",
        PaletteText = "Budeme velmi rádi, pokud svým oblečením podpoříte naši barevnou paletu.",
        PaletteInspoHeading = "Inspirace",
        PaletteInspoText = "Hledáte, co si obléct? Nechte se inspirovat naší paletou — odstíny vínové, rezavé a olivové krásně ladí k podzimní svatbě.",
        PalettePinterestLabel = "Inspirace na Pinterestu",
        PaletteCoolorsLabel = "Paleta v Coolors",

        RsvpHeading = "Potvrďte svou účast",
        RsvpText = "Abychom mohli vše doladit do posledního detailu, prosíme vás o vyplnění krátkého dotazníku. Najdete v něm otázky o vaší účasti, preferencích v jídle a další.",
        RsvpDeadline = "Odpovědi prosíme zaslat ideálně do 1. 7. 2026.",

        ContactHeading = "Máte otázky?",
        ContactText = "Pokud máte jakékoli otázky, napište nám přes formulář níže nebo nás kontaktujte přímo.",
        FormName = "Jméno",
        FormEmail = "E-mail",
        FormMessage = "Zpráva",
        FormSend = "Odeslat",
        FormSending = "Odesílám…",
        FormSuccess = "Děkujeme! Vaše zpráva byla odeslána.",
        FormError = "Něco se pokazilo. Zkuste to prosím znovu nebo nás kontaktujte přímo.",
        ContactOr = "nebo nás kontaktujte přímo",
        PhoneLabel = "Telefon",
        MessengerLabel = "Messenger",

        NavHome = "Domů",
        NavNews = "Aktuálně",
        NavPalette = "Barvy",

        NewsHeading = "Aktuálně",
        NewsEmpty = "Zatím tu nejsou žádné aktuality. Brzy sem přidáme novinky.",

        ProgramHeading = "Program",
        ProgramIntro = "Jak bude probíhat náš svatební víkend. Časy ještě upřesníme.",
        ProgramDays = new[]
        {
            new ProgramDay("Pátek 25. 9.", new[]
            {
                new ProgramEntry("Večer", "Večerní posezení"),
            }),
            new ProgramDay("Sobota 26. 9. — svatební den", new[]
            {
                new ProgramEntry("do 12:00", "Příchod hostů nejpozději ve 12:00"),
                new ProgramEntry("13:00", "Obřad"),
                new ProgramEntry("14:00", "Novomanželské focení a program pro hosty"),
                new ProgramEntry("15:30", "Slavnostní jídlo"),
            }),
            new ProgramDay("Neděle 27. 9.", new[]
            {
                new ProgramEntry("9:00", "Rozloučení a odjezd"),
            }),
        },
        ProgramNote = "Zbytek programu ještě doladíme — podrobnosti brzy doplníme.",

        MenuNavLabel = "Svatební menu",
        MenuHeading = "Svatební menu",
        MenuIntro = "Na náš velký den jsme pro vás připravili následující dobroty. Dobrou chuť!",
        MenuCourses = new[]
        {
            new MenuCourse("Uvítací občerstvení", new[]
            {
                "Zdobené kanapky (různé druhy)",
                "Parmská šunka",
                "Výběr sýrů",
                "Škvarková pomazánka s chlebem",
            }),
            new MenuCourse("Předkrmy a studený raut", new[]
            {
                "Výběr italských a francouzských sýrů",
                "Paštika — zvěřinová, kachní a kuřecí",
                "Carpaccio z červené řepy",
                "Hovězí tatarák s topinkami a česnekem",
            }),
            new MenuCourse("Polévka", new[]
            {
                "Hovězí vývar s játrovými knedlíčky, nudlemi a zeleninou",
            }),
            new MenuCourse("Hlavní chod", new[]
            {
                "Svíčková na smetaně s houskovým knedlíkem",
            }),
            new MenuCourse("Teplý raut", new[]
            {
                "Řízky — kuřecí, vepřový a ze zvěřiny",
                "Hovězí a zvěřinový guláš",
                "Grilovaný hermelín s máslovou zeleninou",
                "Mini burgery",
                "Losos marinovaný v citrusech",
            }),
            new MenuCourse("Saláty", new[]
            {
                "Těstovinový salát",
                "Řecký salát",
                "Mix listových salátů s dresinkem a parmazánem",
            }),
            new MenuCourse("Přílohy", new[]
            {
                "Grilovaná zelenina",
                "Pečené brambory s bylinkami a česnekem",
                "Hranolky",
                "Ratatouille",
                "Výběr pečiva",
            }),
        },
        MenuDietaryNote = "Na přání připravíme i vegetariánskou variantu — maso nahradíme sýrem halloumi, hermelínem nebo tofu. Zohledníme i další dietní omezení, stačí nám dát vědět.",

        FooterSignature = "S láskou",
    };
}
