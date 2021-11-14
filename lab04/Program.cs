using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StartGame();
        }

        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
            Console.WriteLine("Welcome to Tic Tac Toe");
            Console.WriteLine("Please enter the name of the first player");
            string p1 = Console.ReadLine();
            Player myplayer = new Player
            {
                Name = p1,
                Marker = "X",
                IsTurn = true
            };

            Console.WriteLine("Please enter the name of the second player");
            string p2 = Console.ReadLine();
            Player player2 = new Player
            {
                Marker = "O",
                Name = p2,
                IsTurn = false
            };

            Console.Clear();
            Console.WriteLine("Let's start....");

            // Create a new game
            Game game = new Game(myplayer, player2);


            Player winner = game.Play();
            if (!(winner is null))
                Console.WriteLine($"{winner.Name} Wins!");
            else
                Console.WriteLine("It's a draw!");
        }


    }
}