# How to add / edit a news item

The news items (the **News** section on the home page) are read from the **`news.json`**
file in this folder. You don't need to change any code or open Visual Studio — just edit
this JSON file (you can do it right on GitHub via the "pencil" button).

## Adding a new item

Copy one `{ ... }` block and paste it into the list (separated by a comma). The newest
item (highest date) is shown at the top automatically.

```json
{
  "date": "2026-08-15",
  "sk": { "title": "Nadpis po slovensky", "text": "Text aktuality po slovensky." },
  "cz": { "title": "Nadpis česky",        "text": "Text aktuality česky." },
  "en": { "title": "Title in English",     "text": "News text in English." }
}
```

## Rules

- **`date`** must be in the form `YYYY-MM-DD` (e.g. `2026-09-01`). Items are sorted by it.
- The `sk` / `cz` / `en` languages are optional — if you omit one, a fallback translation
  is used (order: Slovak → Czech → English). So you can fill in just `sk`.
- Watch the **commas** between blocks and the **quotes** — JSON is strict about syntax.
  If unsure, validate the file e.g. at <https://jsonlint.com>.
- To temporarily hide an item without deleting it, add `"draft": true` to its block.
  It stays in the file but is not shown on the site. Remove the line (or set it to
  `false`) to show it again.
- If you leave the list empty (`[]`), the News section is not shown on the site at all.

After editing, save / push the change — once deployed (GitHub Pages) the item appears on the site.
