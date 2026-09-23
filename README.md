[Svenska](README_sv.md)

# ChessBoard

**Last updated:** `📆 2026-09-23`\
**Created:** `📆 2026-09-09`\
**Author:** [`iapostolaki`](https://github.com/iapostolaki) [`etc-ludwig`](https://github.com/etc-ludwig)

## About the project
C# console application that renders a chessboard based on user input.

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
◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎
◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎
◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎
◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎
◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎
◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎
```

## Classes and methods
* `Program`
  * `Main()`
    * Main-method where the program starts and calls the other methods
  * `WelcomeMessage()`
    * Prints the welcome message and rules to the user
  * `ValidateInput()`
    * Asks the user for input and then validates it
* `ChessBoard`
  * `RenderBoard()`
    * Renders the chessboard based on the size input

## Git workflow and merge conflicts
In our project, we have worked with Git for version management and to be able to resolve conflicts in a structured way.

### Commits
We have made regular and clear commits with descriptive messages for each completed subtask, function or change.

### Communication and Pulls
During the project, we have had continuous dialogue and screen sharing to check before we posted new changes with `git push`. We made sure to always do a `git pull` before we started working to have the latest version of the code.

### Merge conflicts
When there was a merge conflict in the `main` branch, we went through the overlapping files together, chose which change suited our project best and resolved the conflicts manually before completing the merge.

## Technical choices

### Input Validation
In the `ValidateInput()` method, we use `int.TryParse()` to safely convert the user's input to an integer without crashing the program if invalid characters are entered. We then validate that the number is within the allowed range (3-50). In case of invalid input, we use *Spectre.Console* to display a color-coded and clear error message, and a `while` loop in `Main()` lets the user try again until valid input is given.

### Alternating between black and white squares
The alternation is calculated for each square in the `RenderBoard()` method by checking whether the sum of the current row and the current column is odd or even using modulo calculation (`(row + col) % 2 == 0`). If the sum is even, a white square is printed, otherwise a black one. This gives a perfect checkerboard pattern regardless of the size the user chooses.

### Divided into methods and classes
We have divided the code according to the *Single Responsibility Principle*:
* `WelcomeMessage()` and `ValidateInput()` handle the user interface and input separately in `Program`.
* The game board itself and its printing logic have been moved to a separate class `ChessBoard` according to the Single Responsibility Principle.