using Spectre.Console;

namespace ChessBoard
{
    class Program
    {
        public static int size = 0;
        public static string div = "-----------------------------------";
        private static bool isInputValid = false;

        static void Main(string[] args)
        {
            WelcomeMessage();

            while (!isInputValid)
            {
                Console.Write("Ange storlek: ");
                isInputValid = ValidateInput();
            }

            ChessBoard board1 = new ChessBoard();
            board1.RenderBoard(size);
        }

        public static void WelcomeMessage()
        {
            Console.WriteLine(
                $"{div}" +
                $"\n Välkommen till Bygga Schackbräde!" +
                $"\n{div}" +
                $"\nBestäm storleken (mellan 3-50) på ditt schackbräde.");
        }

        public static bool ValidateInput()
        {
            // Verify that the input is a valid integer
            if (int.TryParse(Console.ReadLine(), out size))
            {
                // Verify that the size is within the allowed range
                if (size >= 3 && size <= 50)
                { 
                    return true;
                }
                else
                {
                    AnsiConsole.MarkupLine("[IndianRed1]Talet är utanför intervallet (mellan 3-50).[/]");
                    return false;
                }
            }
            else
            {
                AnsiConsole.MarkupLine("[IndianRed1]Inmatningen måste vara ett tal.[/]");
            }

            return false;
        }
    }
}