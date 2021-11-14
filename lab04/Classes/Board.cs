using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
	class Board
	{
		/// <summary>
		/// Tic Tac Toe Gameboard states
		/// </summary>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};


		public void DisplayBoard()
		{

			//TODO: Output the board to the console
			int rows = GameBoard.GetLength(0); // rows length
			int columns = GameBoard.GetLength(1); // columns length
			// Console.WriteLine(rows + columns);
			//Output play board to console
			for (int i = 0; i < columns; i++)
			{
				for (int j = 0; j < rows; j++)
				{
					Console.Write(string.Format("|{0}|", GameBoard[i, j]));
				}
				Console.WriteLine();
			}

		}
	}
}