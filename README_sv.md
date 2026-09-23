[English](README.md) 

# ChessBoard

**Senast uppdaterad:** `📆 2026-09-23`\
**Skapad:** `📆 2026-09-09`\
**Utvecklad av:** [`iapostolaki`](https://github.com/iapostolaki) [`etc-ludwig`](https://github.com/etc-ludwig)

## Om projektet
C# konsolapplikation som ritar ut ett schackbräde i terminalen baserat på användarens inmatning.

## Projektets beroenden
### Ramverk
* .NET 10.0 (eller nyare)

### NuGet-paket
* [Spectre.Console](https://www.nuget.org/packages/spectre.console) (v0.57.2) - Formaterad konsolutskrift i C#

## Lokal installation
### 1. Kopiera URL-länken
Klicka på `<>Code` uppe till höger och kopiera HTTPS-länken
```
https://github.com/iapostolaki/chessboard-joanna-ludwig.git
```
### 2. Klona repot
Öppna terminalen eller Git Bash, gå till mappen där du vill spara repot och kör:
```
git clone https://github.com/iapostolaki/chessboard-joanna-ludwig.git
```
### 3. Gå till mappen
```
cd .\ChessBoard\
```
### 4. Bygg och kör programmet
```
dotnet run ChessBoard.csproj
```
För mer information: [GitHub Docs: Cloning a repository](https://docs.github.com/en/repositories/creating-and-managing-repositories/cloning-a-repository)

## Användning
När du kör programmet blir du tillfrågad om hur stort du vill att ditt schackbräde ska bli (intervall 3-50).

Exempel på **inmatning**:
```
6
```

Exempel på **utskrift**, ett 6x6 schackbräde i terminalen: 
```
◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎
◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎
◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎
◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎
◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎
◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎
```

## Klasser och metoder 
* `Program`
  * `Main()`
    * Main-metoden där programmet startar och använder de andra metoderna
  * `WelcomeMessage()`
    * Skriver ut välkomstmeddelandet och reglerna till användaren
  * `ValidateInput()`
    * Frågar användaren efter inmatning och validerar det
* `ChessBoard`
  * `RenderBoard()`
    * Genererar schackbrädet baserat på användarens inmatning

## Git-arbetsflöde och merge-konflikter
I vårat projektet har vi arbetat med Git för versionshantering och för att kunna lösa konflikter på ett strukturerat sätt. 

### Commits
Vi har gjort regelbundna och tydliga commmits med beskrivande meddelanden för varje avslutad deluppgift, funktion eller ändring.

### Kommunikation och Pulls
Vi har under projektets gång haft kontinuerlig dialog och skärmdelat för att stämma av innan vi lagt upp nya ändringar med `git push`. Vi såg till att alltid göra en `git pull` innan vi började arbeta för att ha den senaste versionen av koden.

### Merge-konflikter
När konflikt uppstod i `main`-grenen gick vi igenom de överlappade filerna tillsammans, valde vilken ändring som passade vårat projekt bäst och löste konflikterna manuellt innan vi slutförde mergen.

## Tekniska val

### Inputvalidering
I metoden `ValidateInput()` använder vi `int.TryParse()` för att säkert omvandla användarens inmatning till ett heltal utan att krascha programmet om felaktiga tecken skrivs in. Därefter validerar vi att talet ligger inom det tillåtna intervallet (3-50). Vid felaktig inmatning använder vi *Spectre.Console* för att visa ett färgkodat och tydligt felmeddelande, och en `while`-loop i `Main()` låter användaren försöka igen tills giltig inmatning ges.

### Växling mellan svarta och vita rutor
Växlingen beräknas för varje ruta i `RenderBoard()`-metoden genom att kontrollera om summan av aktuell rad och aktuell kolumn är jämn eller udda med hjälp av moduloräkning (`(row + col) % 2 == 0`). Om summan är jämn ritas en vit ruta ut, annars en svart. Detta ger ett perfekt schackmönster oavsett vilken storlek användaren väljer.

### Uppdelning i metoder och klasser
Vi har delat upp koden enligt principen om ansvarsuppdelning (*Single Responsibility Principle*):
* `WelcomeMessage()` och `ValidateInput()` hanterar användargränssnittet och inläsningen separat i `Program`.
* Själva spelbrädet och dess utskriftslogik har flyttas till en egen klass `ChessBoard` enligt principen om ansvarsuppdelning (*Single Responsibility Principle*).