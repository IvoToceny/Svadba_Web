# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## What this is

A single-page wedding site (landing page) for Deni & Ivo, built as a **Blazor WebAssembly** app
(.NET 10, C#). It is a purely static SPA — no backend. It is multilingual (SK / CZ / EN) and is
deployed for free to GitHub Pages. The contact form posts directly to the third-party
[Web3Forms](https://web3forms.com) API from the browser; RSVP is an external Google Form link.

The audience for the site and most in-code comments is Slovak/Czech.

## Commands

Run all `dotnet` commands from the `SvadbaWeb/` directory.

```bash
cd SvadbaWeb
dotnet watch        # run locally with hot reload (preferred for editing .razor/.cs/.css)
dotnet run          # run without hot reload
dotnet build        # compile only
```

Or open `SvadbaWeb.sln` in Visual Studio and press F5 (hot reload works on save).

There are no tests, no linter, and no separate format step in this project.

Production publish (what CI runs): `dotnet publish SvadbaWeb/SvadbaWeb.csproj -c Release -o build`.

## Architecture

### Localization is the backbone

All user-facing strings live in the localization system, never inline in markup (except a few
fixed proper nouns like surnames). Three layers:

- **`Localization/SiteContent.cs`** — a `record` defining *every* text slot on the site (hero,
  invite, info cards, RSVP, contact form labels, footer). Adding a new piece of text means adding
  a property here first; because properties are `required`, all three language files must then
  supply it or the build fails. This is intentional — it guarantees no language is left behind.
- **`Localization/ContentSk.cs` / `ContentCz.cs` / `ContentEn.cs`** — one static `Value` instance
  of `SiteContent` per language. **This is where you edit actual wording.**
- **`Localization/LocalizationService.cs`** — scoped DI service holding `CurrentLanguage` and the
  active `Content`. Persists the choice to `localStorage` (`svadba.lang`) via JS interop and sets
  `<html lang>`. Raises `OnChanged` when the language switches.

### Components react to language changes via a base class

Any component that displays localized text should inherit **`Components/LocalizedComponentBase`**
(`@inherits LocalizedComponentBase` in `.razor`). It injects `LocalizationService`, exposes the
current content as **`C`** (read text as `C.SomeProperty`), subscribes to `OnChanged`, and calls
`StateHasChanged` on language switch so the UI re-renders live. It implements `IDisposable` to
unsubscribe — if you override `Dispose`, call `base.Dispose()`.

`MainLayout.razor` calls `Loc.InitializeAsync()` once in `OnAfterRenderAsync(firstRender)` to load
the saved language (JS interop isn't available earlier during prerender-less WASM startup).

### Configuration vs. content

- **`Config/SiteConfig.cs`** — non-text settings: external URLs, phone, email, map links, the
  color palette, and the **Web3Forms access key**. These are compile-time `const`s. The contact
  form checks `SiteConfig.ContactFormConfigured` and shows a setup warning until a real key
  replaces the `YOUR-WEB3FORMS-ACCESS-KEY` placeholder.
- Content (wording) is the localization files above; config (links/keys/colors) is here. Keep that
  separation.

### Page structure & styling

- **`Pages/Home.razor`** is the entire site — all sections (hero, invite, info, RSVP, contact,
  footer) in one file. `NotFound.razor` is the 404 fallback (wired in `App.razor`).
- **`wwwroot/css/app.css`** holds all styling. The color palette is defined at the top as CSS
  custom properties (`--burgundy`, `--rust`, …); change colors there. Per-component scoped styles
  may also exist as `.razor.css`.
- Decorative SVGs (botanical sprigs in the hero) are inline `MarkupString`s in `Home.razor`'s
  `@code` block.

## Deployment

`.github/workflows/deploy.yml` publishes to GitHub Pages on every push to `main`. The workflow
rewrites `<base href>` to `/<repo-name>/`, copies `index.html` to `404.html` for SPA fallback
routing, and adds `.nojekyll`. To enable: in the GitHub repo, Settings → Pages → Source =
"GitHub Actions". Until the repo exists, the workflow is inert and the site just runs locally.

## Before going live

Fill these placeholders in `Config/SiteConfig.cs` (see README for details):
`Web3FormsAccessKey` (contact form won't send mail without it), `PhoneNumber`, `MessengerUrl`,
and optionally the map URLs.
