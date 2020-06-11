using System;

namespace rockpaperscissors
{
    public class Player
    {
        public Player()
        {
            
        }

        public HandPlays Play()
        {
            Random rnd = new Random();
            var randomInt = rnd.Next(1,4);
            return (HandPlays)randomInt;
        }
    }
}