using System;

namespace rockpaperscissors
{
    public class Game
    {
        private Player PlayerA { get; set; }
        private int PlayerAScore;   
        private Player PlayerB { get; set; }  
        private int PlayerBScore;   

        public Game(Player A, Player B)
        {
            PlayerA = A;
            PlayerB = B;

            PlayerAScore = 0;
            PlayerBScore = 0;

        }

        public void RunRound()
        {
            var handA = PlayerA.Play();
            var handB = PlayerB.Play();
            System.Console.WriteLine($"Play A played: {handA.ToString()} \nPlay B played: {handB.ToString()}");

            CompareHands(handA, handB);
            System.Console.WriteLine($"Play A: {PlayerAScore} \tPlay B: {PlayerBScore}");
        }

        public void GetSummary()
        {
            System.Console.WriteLine($"\n-----FINAL SCORE-----");
            if (PlayerAScore > PlayerBScore)
            {
                System.Console.WriteLine($"Play A: {PlayerAScore} \tPlay B: {PlayerBScore}");
                System.Console.WriteLine($"Player A WINS!!!!");
            }
            else if (PlayerAScore < PlayerBScore)
            {
                System.Console.WriteLine($"Play A: {PlayerAScore} \tPlay B: {PlayerBScore}");
                System.Console.WriteLine($"Player B WINS!!!!");
            }
        }

        private void CompareHands(HandPlays handA, HandPlays handB)
        {
            if ((handA == HandPlays.Rock && handB == HandPlays.Scissors)
            ||(handA == HandPlays.Scissors && handB == HandPlays.Paper)
            ||(handA == HandPlays.Paper && handB == HandPlays.Rock))
            {
                PlayerAScore ++;
            }
            
            if ((handB == HandPlays.Rock && handA == HandPlays.Scissors)
            ||(handB == HandPlays.Scissors && handA == HandPlays.Paper)
            ||(handB == HandPlays.Paper && handA == HandPlays.Rock))
            {
                PlayerBScore ++;
            }
        }
    }
}