# ChessBoard

**Last updated:** `📆 2026-09-17`\
**Created:** `📆 2026-09-09`\
**Author:** [`iapostolaki`](https://github.com/iapostolaki) [`etc-ludwig`](https://github.com/etc-ludwig)
<!-- 
> [!WARNING]
> README still under construction! 
-->

## About the project
C# console application that renders a chessboard.

## Dependencies
### Framework
* .NET 10.0 (or higher)

### NuGet Packages
* [Spectre.Console](https://www.nuget.org/packages/spectre.console) (v0.57.2) - Formatted console output in C#

## Local Setup
### 1. Copy the URL
Click `<>Code` on the top right and copy the HTTPS URL
```
https://github.com/iapostolaki/chessboard-joanna-ludwig.git
```
### 2. Clone the repo 
Open the terminal or Git Bash, navigate to the folder you want the repository to be cloned in and use:
```
git clone https://github.com/iapostolaki/chessboard-joanna-ludwig.git
```
### 3. Step into the folder
```
cd .\ChessBoard\
```
### 4. Build and run the program
```
dotnet run ChessBoard.csproj
```
For more information: [GitHub Docs: Cloning a repository](https://docs.github.com/en/repositories/creating-and-managing-repositories/cloning-a-repository)

## Usage
When you run the application you will be asked how big you want your chessboard to be (interval 3-50).

Example **input**:
```
6
```

Example **output**, a 6x6 chessboard in the terminal:
```
◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎
◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎
◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎
◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎
◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎
◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎
```

## Classes and methods
* `Program`
  * `Main()`
  * `WelcomeMessage()`
  * `GetInput()`
* `ChessBoard`
  * `RenderBoard()`
