# Wedding site — Denisa & Ivo 💍

A multilingual (SK / CZ / EN), responsive wedding site (works on both mobile and desktop),
built on **Blazor WebAssembly (.NET 10, C#)**. Editable in Visual Studio with **Hot Reload**.

- 📅 26 Sep 2026 · Lysovický pond near Vyškov
- 📝 RSVP via Google Form: <https://forms.gle/tMXnmMwSWMaMJU6y6>
- ✉️ The contact form sends mail to `ivo6770@gmail.com` (via the Web3Forms service)

It is a **purely static site** — no server, no database. That is why it can be hosted
for free on GitHub Pages.

---

## 1. Running locally (with Hot Reload)

Prerequisite: the **.NET 10 SDK** installed (or open `SvadbaWeb.sln` in Visual Studio).

### A) Visual Studio
1. Open `SvadbaWeb.sln`.
2. Press **F5**. When you edit `.razor` / `.cs` / `.css` files, the changes apply via **Hot Reload**.

### B) Command line
```bash
cd SvadbaWeb
dotnet watch
```
A browser opens at `http://localhost:5202`. After you save a file the page re-renders itself.

> 💡 **Tip:** do not add binary files (images, PDFs) to the project **while the server is running** —
> it can cause it to get stuck on "Loading…". In that case stop the server, add the file and start again.
> If it still hangs, a **hard refresh** of the browser helps (Ctrl+Shift+R).

---

## 2. Project structure

```
Svadba_Web/
├─ README.md                  ← this file
├─ LICENSE
├─ .gitignore                 ← what is NOT versioned (build output, personal materials – see below)
├─ .github/workflows/deploy.yml   ← automatic deployment to GitHub Pages (on push to main)
├─ SvadbaWeb.sln              ← Visual Studio solution
└─ SvadbaWeb/                 ← the project itself
   ├─ SvadbaWeb.csproj        ← project and package definition
   ├─ Program.cs              ← app startup + service registration
   ├─ App.razor               ← router – maps URLs to pages
   ├─ _Imports.razor          ← shared `@using` for all .razor files
   │
   ├─ Layout/
   │  └─ MainLayout.razor     ← shared frame for every page (nav bar + content)
   │
   ├─ Pages/                  ← individual pages (each has its own URL)
   │  ├─ Home.razor           →  /            home (hero as the invitation, info, contact)
   │  ├─ Aktuality.razor      →  /aktuality   announcements / news
   │  ├─ Program.razor        →  /program     the wedding-weekend schedule
   │  ├─ Menu.razor           →  /menu        the wedding menu
   │  ├─ Palette.razor        →  /paleta      colour palette + inspiration
   │  └─ NotFound.razor       →  404 (non-existent address)
   │
   ├─ Components/             ← reusable UI pieces
   │  ├─ NavBar.razor             top menu (tabs + language switcher)
   │  ├─ LanguageSwitcher.razor   SK / CZ / EN buttons
   │  ├─ InfoCard.razor           one card in the "Important information" section
   │  ├─ ContactForm.razor        contact form (sends mail via Web3Forms)
   │  ├─ NewsSection.razor        renders the news (used by the /aktuality page)
   │  └─ LocalizedComponentBase.cs  shared base – exposes texts via `C` and re-renders on language change
   │
   ├─ Localization/          ← ALL site TEXTS (translations)
   │  ├─ Language.cs              the list of languages (Sk / Cz / En)
   │  ├─ SiteContent.cs          the "template" – which texts the site has (the field list)
   │  ├─ ContentSk.cs            🇸🇰 Slovak texts   ← edit SK content here
   │  ├─ ContentCz.cs            🇨🇿 Czech texts    ← edit CZ content here
   │  ├─ ContentEn.cs            🇬🇧 English texts  ← edit EN content here
   │  └─ LocalizationService.cs  holds the current language (and remembers the choice in the browser)
   │
   ├─ News/                  ← news logic
   │  ├─ NewsItem.cs             model of a single news item
   │  └─ NewsService.cs          loads the news from the news.json file
   │
   ├─ Config/
   │  └─ SiteConfig.cs        ← LINKS AND SETTINGS (form, phone, maps, palette, keys)
   │
   └─ wwwroot/               ← static files served as-is on the web
      ├─ index.html             HTML shell + fonts + initial "loading" screen
      ├─ css/app.css            the ENTIRE look (colours, layout, responsiveness)
      ├─ img/hero-top.png       botanical flowers at the top of the home page (cut from the invitation)
      ├─ img/hero-bottom.png    botanical flowers at the bottom of the home page
      ├─ favicon.png, icon-192.png   icons
      └─ data/
         ├─ news.json                  ← NEWS CONTENT (add announcements here)
         └─ HOW-TO-ADD-NEWS.md    guide on how to add a news item
```

---

## 3. How it works (in short)

- **Routing:** every page in `Pages/` has `@page "/address"` at the top. When you change the
  URL or click in the menu, `App.razor` shows the matching page **without reloading the whole
  page** (it is a single-page application – SPA).
- **Shared frame:** `Layout/MainLayout.razor` wraps every page – that is why the top menu
  (`NavBar`) is the same everywhere.
- **Texts and languages:** no texts are "hard-coded" in the pages. They live in `Localization/` –
  `SiteContent.cs` declares *which* texts exist, and `ContentSk/Cz/En.cs` hold the *actual
  translations*. A component reads a text via `C.SomeProperty`. When the language is switched the
  page re-renders itself and the choice is saved in the browser (localStorage).
- **News:** kept separate from the code in `wwwroot/data/news.json`. The site loads it at
  runtime. Thanks to that a news item can be added **without programming** (even directly on
  GitHub) – the guide is in `wwwroot/data/HOW-TO-ADD-NEWS.md`.
- **Contact form:** has no server – it submits via the free **Web3Forms** service, which
  forwards the content to e-mail. It needs a key in `SiteConfig.cs` (see section 5).
- **RSVP:** it is a link to a **Google Form** (not part of the code). You can view the
  responses in the linked **Google Sheet** (shared only with you) — they are not put on the web.

---

## 4. Where to change what (most common)

| What I want to change | Where |
|---|---|
| **Slovak / Czech / English texts** | `SvadbaWeb/Localization/ContentSk.cs` / `ContentCz.cs` / `ContentEn.cs` |
| **Add / edit a news item** | `SvadbaWeb/wwwroot/data/news.json` (guide next to it) |
| **Wedding schedule (times)** | the `ProgramDays` section in `ContentSk/Cz/En.cs` |
| **Wedding menu (dishes)** | the `MenuCourses` section in `ContentSk/Cz/En.cs` |
| **Links, contact, keys, palette** | `SvadbaWeb/Config/SiteConfig.cs` |
| **Look / colours / layout** | `SvadbaWeb/wwwroot/css/app.css` |
| **Top menu items** | `SvadbaWeb/Components/NavBar.razor` |
| **Order of sections on the home page** | `SvadbaWeb/Pages/Home.razor` |

> The colour palette is at the very top of `app.css` as CSS variables (`--burgundy`, `--rust`, …) —
> changing one value repaints the whole site.

---

## 5. ⚠️ Before going live, fill in `SvadbaWeb/Config/SiteConfig.cs`

These must contain real values (already filled in this repo):

1. **`Web3FormsAccessKey`** — register for free at <https://web3forms.com> (use the mail
   `ivo6770@gmail.com`), copy the *Access Key* and paste it here. Without it the contact form
   cannot send mail.
2. **`PhoneNumber`** — the phone number for the contact button.
3. **`MessengerUrl`** — the Messenger link (e.g. `https://m.me/your.name`).

*(The venue, map and accommodation links are already filled with real URLs.)*

---

## 6. Personal data — what does NOT belong on the web

The site is public, so **anything in the `wwwroot` folder can be downloaded by anyone.**
That is why these are in `.gitignore` and are **not versioned** (they never reach the web):

- `wwwroot/*.pdf` — e.g. the filled-in catering questionnaire (it contains phone numbers and e-mails),
- `wwwroot/*.xlsx` / `*.xls` / `*.csv` — the guest list,
- the working photo `591772843_*.jpg`.

**Keep the guest list and RSVP status in the Google Sheet** (linked to the form) and share it
only with your partner — not on the web.

---

## 7. Deployment to the web (GitHub Pages, free)

Automatic deployment via `.github/workflows/deploy.yml` is **enabled** — every push to `main`
builds and deploys the site. To make it actually go live:

1. **Set the repo to public.** Free GitHub Pages only works for public repositories.
   (A private one would require the paid GitHub Pro plan.)
2. **Settings → Pages → Source = "GitHub Actions".**
3. From then on, every push to `main` automatically builds and deploys the site to
   `https://<your-login>.github.io/<repo-name>/`. You can also trigger it manually from the
   **Actions** tab → *Run workflow*.
4. After the first successful deploy, enable **Settings → Pages → Enforce HTTPS**.

No server or paid hosting is needed.
