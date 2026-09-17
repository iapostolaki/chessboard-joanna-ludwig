using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Spectre.Console;

namespace ChessBoard
{
    public class ChessBoard
    {
        // Properties for the black and white 
        public string WhiteSquare { get; set; }
        public string BlackSquare { get; set; }

        // Constructor
        public ChessBoard()
        {
            WhiteSquare = "[NavajoWhite1]◼︎ [/]";
            BlackSquare = "[LightPink4]◼︎ [/]";
        }

        public void RenderBoard(int size) 
        {
            // Print the ChessBoard
            for (int row = 1; row <= size; row++)
            {
                for (int col = 1; col <= size; col++)
                {
                    //If the sum of row and column is even, the square is white; otherwise, black.
                    if ((row + col) % 2 == 0)
                    {
                        AnsiConsole.Markup(BlackSquare);
                    }
                    else
                    {
                        AnsiConsole.Markup(WhiteSquare);
                    }
                }
                // Make a new line
                Console.WriteLine();
            }
        }

    }
}
