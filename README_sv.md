[English](README.md) 

# ChessBoard

**Senast uppdaterad:** `📆 2026-09-21`\
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
◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎
◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎
◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎
◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎
◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎
◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎
```

## Klasser och metoder 
* `Program`
  * `Main()`
    * Main-metoden där programmet startar och använder de andra metoderna
  * `WelcomeMessage()`
    * Skriver ut välkomstmeddelandet och reglerna till användaren
  * `GetInput()`
    * Frågar användaren efter inmatning och validerar det
* `ChessBoard`
  * `RenderBoard()`
    * Genererar schackbrädet baserat på användarens inmatning

## Git-arbete


## Tekniska val
