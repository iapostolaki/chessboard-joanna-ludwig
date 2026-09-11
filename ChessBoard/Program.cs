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

            while (!isInputValid)
            {   
                Console.Write("Ange ett tal: ");
                string input = Console.ReadLine();
                
                if (int.TryParse(input, out int size))
                {
                    Console.WriteLine("Giltig inmatning!!! JA!!!!!");
                }
                else
                {
                    Console.WriteLine("Ogiltig inmatning");
                }

            }

        }
    }
}