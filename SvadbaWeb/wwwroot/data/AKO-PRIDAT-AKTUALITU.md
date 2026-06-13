# Ako pridať / upraviť aktualitu

Aktuality (sekcia **Aktuality** na hlavnej stránke) sa berú zo súboru **`news.json`**
v tomto priečinku. Netreba meniť žiadny kód ani spúšťať Visual Studio — stačí upraviť
tento JSON súbor (kľudne aj priamo na GitHube cez tlačidlo „ceruzka").

## Pridanie novej aktuality

Skopíruj jeden blok `{ ... }` a vlož ho do zoznamu (oddelený čiarkou). Najnovšia
aktualita (najvyšší dátum) sa zobrazí navrchu automaticky.

```json
{
  "date": "2026-08-15",
  "sk": { "title": "Nadpis po slovensky", "text": "Text aktuality po slovensky." },
  "cz": { "title": "Nadpis česky",        "text": "Text aktuality česky." },
  "en": { "title": "Title in English",     "text": "News text in English." }
}
```

## Pravidlá

- **`date`** musí byť v tvare `RRRR-MM-DD` (napr. `2026-09-01`). Podľa neho sa aktuality radia.
- Jazyky `sk` / `cz` / `en` sú voliteľné — ak niektorý vynecháš, použije sa náhradný
  preklad (poradie: slovenčina → čeština → angličtina). Pokojne teda vyplň len `sk`.
- Dávaj pozor na **čiarky** medzi blokmi a na **úvodzovky** — JSON je citlivý na syntax.
  Ak si neistý, over súbor napr. na <https://jsonlint.com>.
- Ak necháš zoznam prázdny (`[]`), sekcia Aktuality sa na stránke vôbec nezobrazí.

Po úprave zmenu ulož / pushni — po nasadení (GitHub Pages) sa aktualita objaví na stránke.
