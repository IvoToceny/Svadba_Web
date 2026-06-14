# Svadobná stránka — Denisa & Ivo 💍

Viacjazyčná (SK / CZ / EN) svadobná stránka, responzívna (funguje na mobile aj počítači),
postavená na **Blazor WebAssembly (.NET 10, C#)**. Editovateľná vo Visual Studiu s **Hot Reload**.

- 📅 26. 9. 2026 · Lysovický rybník pri Vyškove
- 📝 RSVP cez Google formulár: <https://forms.gle/tMXnmMwSWMaMJU6y6>
- ✉️ Kontaktný formulár posiela mail na `ivo6770@gmail.com` (cez službu Web3Forms)

Je to **čisto statická stránka** — žiadny server, žiadna databáza. Vďaka tomu sa dá
zadarmo hostiť na GitHub Pages.

---

## 1. Spustenie lokálne (s Hot Reloadom)

Predpoklad: nainštalovaný **.NET 10 SDK** (alebo otvor `SvadbaWeb.sln` vo Visual Studiu).

### A) Visual Studio
1. Otvor `SvadbaWeb.sln`.
2. Stlač **F5**. Pri úprave `.razor` / `.cs` / `.css` súborov sa zmeny prejavia cez **Hot Reload**.

### B) Príkazový riadok
```bash
cd SvadbaWeb
dotnet watch
```
Otvorí sa prehliadač na `http://localhost:5202`. Po uložení súboru sa stránka sama prekreslí.

> 💡 **Tip:** binárne súbory (obrázky, PDF) **nepridávaj do projektu, kým beží server** —
> vie to spôsobiť zaseknutie na „Načítavam…". Vtedy server zastav, pridaj súbor a spusti znova.
> Ak sa to aj tak zasekne, pomôže **tvrdé obnovenie** prehliadača (Ctrl+Shift+R).

---

## 2. Štruktúra projektu

```
Svadba_Web/
├─ README.md                  ← tento súbor
├─ LICENSE
├─ .gitignore                 ← čo sa NEverzuje (build, osobné podklady – viď nižšie)
├─ .github/workflows/deploy.yml   ← automatické nasadenie na GitHub Pages (teraz vypnuté)
├─ SvadbaWeb.sln              ← solution pre Visual Studio
└─ SvadbaWeb/                 ← samotný projekt
   ├─ SvadbaWeb.csproj        ← definícia projektu a balíčkov
   ├─ Program.cs              ← štart aplikácie + registrácia služieb
   ├─ App.razor               ← smerovač (router) – spája URL adresy so stránkami
   ├─ _Imports.razor          ← spoločné `@using` pre všetky .razor súbory
   │
   ├─ Layout/
   │  └─ MainLayout.razor     ← spoločná kostra každej stránky (nav bar + obsah)
   │
   ├─ Pages/                  ← jednotlivé stránky (každá má svoju URL)
   │  ├─ Home.razor           →  /            domov (hero ako pozvánka, info, kontakt)
   │  ├─ Aktuality.razor      →  /aktuality   oznámenia/novinky
   │  ├─ Program.razor        →  /program     program svadobného víkendu
   │  ├─ Menu.razor           →  /menu        svadobné menu
   │  ├─ Palette.razor        →  /paleta      farebná paleta + inšpirácia
   │  └─ NotFound.razor       →  404 (neexistujúca adresa)
   │
   ├─ Components/             ← znovupoužiteľné kúsky UI
   │  ├─ NavBar.razor             horné menu (taby + prepínač jazykov)
   │  ├─ LanguageSwitcher.razor   tlačidlá SK / CZ / EN
   │  ├─ InfoCard.razor           jedna kartička v sekcii „Dôležité informácie"
   │  ├─ ContactForm.razor        kontaktný formulár (posiela mail cez Web3Forms)
   │  ├─ NewsSection.razor        výpis aktualít (používa ho stránka /aktuality)
   │  └─ LocalizedComponentBase.cs  spoločný základ – sprístupní texty cez `C` a prekreslí pri zmene jazyka
   │
   ├─ Localization/          ← VŠETKY TEXTY stránky (preklady)
   │  ├─ Language.cs              zoznam jazykov (Sk / Cz / En)
   │  ├─ SiteContent.cs          „šablóna" – aké texty stránka má (zoznam polí)
   │  ├─ ContentSk.cs            🇸🇰 slovenské texty   ← tu meníš SK obsah
   │  ├─ ContentCz.cs            🇨🇿 české texty       ← tu meníš CZ obsah
   │  ├─ ContentEn.cs            🇬🇧 anglické texty    ← tu meníš EN obsah
   │  └─ LocalizationService.cs  drží aktuálny jazyk (a pamätá si voľbu v prehliadači)
   │
   ├─ News/                  ← logika aktualít
   │  ├─ NewsItem.cs             model jednej aktuality
   │  └─ NewsService.cs          načíta aktuality zo súboru news.json
   │
   ├─ Config/
   │  └─ SiteConfig.cs        ← ODKAZY A NASTAVENIA (formulár, telefón, mapy, paleta, kľúče)
   │
   └─ wwwroot/               ← statické súbory, ktoré idú 1:1 na web
      ├─ index.html             HTML kostra + fonty + úvodná „načítavacia" obrazovka
      ├─ css/app.css            CELÝ vzhľad (farby, layout, responzivita)
      ├─ img/hero-top.png       botanické kvety hore na domove (výrez z pozvánky)
      ├─ img/hero-bottom.png    botanické kvety dole na domove
      ├─ motiv.jpg              originálna pozvánka (zdroj kvetov)
      ├─ favicon.png, icon-192.png   ikonky
      └─ data/
         ├─ news.json                  ← OBSAH AKTUALÍT (tu pridávaš novinky)
         └─ AKO-PRIDAT-AKTUALITU.md    návod, ako pridať aktualitu
```

---

## 3. Ako to funguje (v skratke)

- **Smerovanie (routing):** každá stránka v `Pages/` má navrchu `@page "/adresa"`. Keď
  zmeníš URL alebo klikneš v menu, `App.razor` zobrazí príslušnú stránku **bez načítania
  celej stránky** (je to jednostránková aplikácia – SPA).
- **Spoločná kostra:** `Layout/MainLayout.razor` obaľuje každú stránku – preto je horné
  menu (`NavBar`) všade rovnaké.
- **Texty a jazyky:** žiadne texty nie sú „natvrdo" v stránkach. Sú v `Localization/` –
  `SiteContent.cs` hovorí, *aké* texty existujú, a `ContentSk/Cz/En.cs` obsahujú *konkrétne
  preklady*. Komponent prečíta text cez `C.NiektoreLole`. Pri prepnutí jazyka sa stránka
  sama prekreslí a voľba sa uloží do prehliadača (localStorage).
- **Aktuality:** sú oddelené od kódu v súbore `wwwroot/data/news.json`. Stránka si ho
  načíta za behu. Vďaka tomu sa dá novinka pridať **bez programovania** (aj priamo na
  GitHube) – návod je v `wwwroot/data/AKO-PRIDAT-AKTUALITU.md`.
- **Kontaktný formulár:** nemá server – odosiela cez bezplatnú službu **Web3Forms**, ktorá
  pošle obsah na mail. Potrebuje kľúč v `SiteConfig.cs` (viď časť 5).
- **RSVP:** je to odkaz na **Google formulár** (nie je súčasťou kódu). Odpovede si vieš
  pozerať v prepojenej **Google tabuľke** (zdieľanej len vám) — na web sa nedávajú.

---

## 4. Kde čo meniť (najčastejšie)

| Čo chcem zmeniť | Kde |
|---|---|
| **Slovenské / české / anglické texty** | `SvadbaWeb/Localization/ContentSk.cs` / `ContentCz.cs` / `ContentEn.cs` |
| **Pridať / upraviť aktualitu** | `SvadbaWeb/wwwroot/data/news.json` (návod vedľa) |
| **Program svadby (časy)** | sekcia `ProgramDays` v `ContentSk/Cz/En.cs` |
| **Svadobné menu (jedlá)** | sekcia `MenuCourses` v `ContentSk/Cz/En.cs` |
| **Odkazy, kontakt, kľúče, paleta** | `SvadbaWeb/Config/SiteConfig.cs` |
| **Vzhľad / farby / layout** | `SvadbaWeb/wwwroot/css/app.css` |
| **Položky horného menu** | `SvadbaWeb/Components/NavBar.razor` |
| **Poradie sekcií na domove** | `SvadbaWeb/Pages/Home.razor` |

> Farebná paleta je v `app.css` úplne hore ako CSS premenné (`--burgundy`, `--rust`, …) —
> zmena jednej hodnoty premaľuje celú stránku.

---

## 5. ⚠️ Pred ostrým spustením vyplň v `SvadbaWeb/Config/SiteConfig.cs`

1. **`Web3FormsAccessKey`** — zaregistruj sa zadarmo na <https://web3forms.com> (zadaj mail
   `ivo6770@gmail.com`), skopíruj *Access Key* a vlož ho sem. Bez neho kontaktný formulár
   neodošle mail (na stránke sa zobrazí upozornenie).
2. **`PhoneNumber`** — telefónne číslo pre kontaktné tlačidlo.
3. **`MessengerUrl`** — odkaz na Messenger (napr. `https://m.me/tvoje.meno`).

*(Odkazy na areál, mapu a ubytovanie sú už vyplnené reálnymi linkami.)*

---

## 6. Osobné údaje — čo NEpatrí na web

Stránka je verejná, takže **čokoľvek v priečinku `wwwroot` si vie stiahnuť ktokoľvek.**
Preto sú v `.gitignore` a **neverzujú sa** (nedostanú sa na web):

- `wwwroot/*.pdf` — napr. vyplnený dotazník od cateringu (sú v ňom telefóny a maily),
- `wwwroot/*.xlsx` / `*.xls` / `*.csv` — zoznam hostí,
- pracovná fotka `591772843_*.jpg`.

**Zoznam hostí a stav RSVP drž v Google tabuľke** (prepojenej s formulárom) a zdieľaj ju
len partnerke — nie na webe.

---

## 7. Nasadenie na web (GitHub Pages, zadarmo)

Automatické nasadenie cez `.github/workflows/deploy.yml` je **zatiaľ vypnuté**
(aby sa stránka predčasne nezverejnila). Keď ju budeš chcieť spustiť naživo:

1. **Repo nastav na verejné (public).** Bezplatné GitHub Pages fungujú len pre verejné
   repozitáre. (Súkromné by vyžadovali platený GitHub Pro.)
2. **Settings → Pages → Source = „GitHub Actions".**
3. Vo `deploy.yml` odkomentuj dva riadky `push:` / `branches: [ main ]` (návod je priamo
   v súbore). Odvtedy sa po každom pushi do `main` stránka sama zostaví a nasadí na
   `https://<tvoj-login>.github.io/<nazov-repa>/`.

Žiadny server ani platený hosting netreba.
