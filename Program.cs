using System;

namespace rockpaperscissors
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var playerA = new Player();
            var playerB = new Player();
            var game = new Game(playerA, playerB);

            bool playAgain = true;

            while(playAgain)
            {
                game.RunRound();

                System.Console.WriteLine("Continue Game (y/n)");
                var selection = Console.ReadLine();

                if( selection == "n" )
                {
                    playAgain = false;
                }
            } 
            game.GetSummary();
        }
    }
}
