namespace ChessBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isInputValid = false;
            string div = "-----------------------------------";

            Console.WriteLine(div);
            Console.WriteLine(" Välkommen till vårat Schackbräde!");
            Console.WriteLine(div);

            Console.WriteLine("Bestäm storleken (mellan 3-50) på ditt schackbräde.");

            // Sålänge inmatningen är ogiltig, fråga igen. 
            while (!isInputValid)
            {   
                Console.Write("Ange ett tal: ");
                string input = Console.ReadLine();
                
                // Kollar så att inmatningen till en siffra
                if (int.TryParse(input, out int size))
                {
                    // Kollar så att det är inom intervallet
                    if (size >= 3 && size <= 50)
                    {
                        Console.WriteLine("Giltigt!");
                        // Här måste vi stoppa while-loopen, testa programmet så minns ni :)
                    }
                    else
                    {
                        Console.WriteLine("Ogiltigt inmatning.");
                    }
                }
                else
                {
                    Console.WriteLine("Inmatningen måste vara ett tal.");
                }

            }

        }
    }
}