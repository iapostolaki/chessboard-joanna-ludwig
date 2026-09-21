using Spectre.Console;

namespace ChessBoard
{
    class Program
    {
        public static int size = 0;
        public static string div = "-----------------------------------";

        static void Main(string[] args)
        {
            
            bool isInputValid = false;

            WelcomeMessage();

            while (!isInputValid)
            {
                Console.Write("Ange storlek: ");
                isInputValid = GetInput();
            }

            ChessBoard board1 = new ChessBoard();
            board1.RenderBoard(size);
        }

        public static void WelcomeMessage()
        {
            Console.WriteLine($"{div}" +
                $"\n Välkommen till ditt Schackbräde!" +
                $"\n{div}" +
                $"\nBestäm storleken (mellan 3-50) på ditt schackbräde.");
        }

        public static bool GetInput()
        {
            // Verify that the input is valid integer
            if (int.TryParse(Console.ReadLine(), out size))
            {
                // Verify that the size is within the allowed range
                if (size >= 3 && size <= 50)
                { 
                    return true;
                }
                else
                {
                    AnsiConsole.MarkupLine("[IndianRed1]Talet är utanför intervallet.[/]");
                    return false;
                }
            }
            else
            {
                AnsiConsole.MarkupLine("[IndianRed1]Inmatningen måste vara ett tal mellan 3-50.[/]");
            }

            return false;
        }
    }
}