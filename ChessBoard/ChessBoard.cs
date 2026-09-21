using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Spectre.Console;

namespace ChessBoard
{
    public class ChessBoard
    {
        // Properties
        public string WhiteSquare { get; set; }
        public string BlackSquare { get; set; }

        // Constructor
        public ChessBoard()
        {
            WhiteSquare = "[NavajoWhite1]◼︎ [/]";
            BlackSquare = "[LightPink4]◻︎ [/]";
        }

        public void RenderBoard(int size)
        {
            AnsiConsole.MarkupLine("[LightGreen]Här är ditt schackbräde![/]\n");

            // Print the ChessBoard
            for (int row = 1; row <= size; row++)
            {
                for (int col = 1; col <= size; col++)
                {
                    //If the sum of row and column is even, the square is white; otherwise, black.
                    if ((row + col) % 2 == 0)
                    {
                        AnsiConsole.Markup(WhiteSquare);
                    }
                    else
                    {
                        AnsiConsole.Markup(BlackSquare);
                    }
                }
                // Make a new line
                Console.WriteLine();
            }
        }

    }
}
