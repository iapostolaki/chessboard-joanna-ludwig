using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ChessBoard
{
    public class ChessBoard
    {
        //properties
        public string WhiteSquare { get; set; }
        public string BlackSquare { get; set; }

        //Constructor
        public ChessBoard()
        {
            WhiteSquare = "◼︎ ";
            BlackSquare = "◻︎ ";
        }

        public void RenderBoard(int size) 
        {
            // Skriver ut schackbräde
            for (int row = 1; row <= size; row++)
            {
                for (int col = 1; col <= size; col++)
                {
                    if ((row + col) % 2 == 0)
                    {
                        Console.Write(BlackSquare);
                    }
                    else
                    {
                        Console.Write(WhiteSquare);
                    }
                }
                // Gör en ny rad
                Console.WriteLine();
            }
        }

    }
}
