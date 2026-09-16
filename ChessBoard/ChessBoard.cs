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
        public int Size { get; set; }


        //Constructor
        public ChessBoard(int size)
        {
            WhiteSquare = "◼︎ ";
            BlackSquare = "◻︎ ";
            Size = size;
        }

        public void RenderBoard() 
        {
            // Skriver ut schackbräde
            for (int row = 1; row <= Size; row++)
            {
                for (int col = 1; col <= Size; col++)
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
