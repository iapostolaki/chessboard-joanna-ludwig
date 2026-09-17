namespace ChessBoard
{
    class Program
    {
        public static int size = 0;
        public static bool isInputValid = false;
        public static string div = "-----------------------------------";

        static void Main(string[] args)
        {
            // Skriv kommentarer på engelska

            Console.WriteLine(div);
            Console.WriteLine(" Välkommen till vårat Schackbräde!");
            Console.WriteLine(div);

            Console.WriteLine("Bestäm storleken (mellan 3-50) på ditt schackbräde.");

            while (!isInputValid)
            {
                Console.Write("Ange ett tal: ");
                isInputValid = GetInput();
            }

            ChessBoard board1 = new ChessBoard();
            board1.RenderBoard(size);
        }

        public static bool GetInput()
        {
            // Kollar så att inmatningen är en siffra
            if (int.TryParse(Console.ReadLine(), out size))
            {
                // Kollar så att det är inom intervallet
                if (size >= 3 && size <= 50)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Ogiltigt inmatning.");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Inmatningen måste vara ett tal.");
            }

            return false;
        }
    }
}