# Svadobná stránka — Deni & Ivo 💍

Jednostránková (landing page) svadobná stránka. Responzívna, viacjazyčná (SK / CZ / EN),
postavená na **Blazor WebAssembly (.NET 10, C#)**. Editovateľná vo Visual Studiu s **hot reload**.

- 📅 26. 9. 2026 · Lysovický rybník pri Vyškove
- 📝 RSVP cez Google formulár: https://forms.gle/tMXnmMwSWMaMJU6y6
- ✉️ Kontaktný formulár posiela mail na `ivo6770@gmail.com` (cez Web3Forms)

---

## Spustenie lokálne (s hot reloadom)

Predpoklad: nainštalovaný **.NET 10 SDK** (alebo otvor `SvadbaWeb.sln` vo Visual Studiu).

### A) Visual Studio
1. Otvor `SvadbaWeb.sln`.
2. Stlač **F5** (alebo Ctrl+F5). Pri úprave `.razor` / `.cs` / `.css` súborov sa zmeny
   prejavia cez **Hot Reload** okamžite.

### B) Príkazový riadok (najrýchlejší hot reload)
```bash
cd SvadbaWeb
dotnet watch
```
Otvorí sa prehliadač na `https://localhost:xxxx`. Po uložení ľubovoľného súboru sa stránka
sama prekreslí.

---

## Kde čo meniť

| Čo chcem zmeniť | Súbor |
|---|---|
| **Slovenské texty** | `SvadbaWeb/Localization/ContentSk.cs` |
| **České texty** | `SvadbaWeb/Localization/ContentCz.cs` |
| **Anglické texty** | `SvadbaWeb/Localization/ContentEn.cs` |
| **Odkazy, kontakt, kľúče** | `SvadbaWeb/Config/SiteConfig.cs` |
| **Vzhľad / farby / layout** | `SvadbaWeb/wwwroot/css/app.css` |
| **Štruktúra stránky (sekcie)** | `SvadbaWeb/Pages/Home.razor` |

Farebná paleta je v `app.css` hore ako CSS premenné (`--burgundy`, `--rust`, …).

---

## ⚠️ Pred ostrým nasadením vyplň v `SvadbaWeb/Config/SiteConfig.cs`

1. **`Web3FormsAccessKey`** — zaregistruj sa zadarmo na <https://web3forms.com>
   (zadaj mail `ivo6770@gmail.com`), skopíruj *Access Key* a vlož ho sem.
   Bez neho kontaktný formulár neodošle mail (na stránke sa zobrazí upozornenie).
2. **`PhoneNumber`** — tvoje telefónne číslo pre kontaktné tlačidlo.
3. **`MessengerUrl`** — tvoj Messenger odkaz (napr. `https://m.me/tvoje.meno`).
4. *(voliteľné)* `VenueMapUrl` / `HotelMapUrl` — presné odkazy na mapu/hotel.

---

## Nasadenie na web (zadarmo, neskôr)

Pripravený je GitHub Actions workflow `.github/workflows/deploy.yml`:

1. Vytvor GitHub repo (napr. `Svadba_Web`) a pushni doň tento priečinok.
2. V repo: **Settings → Pages → Source = „GitHub Actions"**.
3. Po každom pushi do `main` sa stránka sama zostaví a nasadí na
   `https://<tvoj-login>.github.io/<nazov-repa>/`.

Žiadny server ani platený hosting netreba — je to čisto statická stránka.
