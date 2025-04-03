using System;

namespace PlayerStats
{
    class Player
    {
        private float highScore;
        private int matches;
        private int wins;
        public float HighScore
        {
            get => highScore;
            set
            {
                if (value > highScore)
                {
                    highScore = value;
                }
            }
        }

        public string Name { get; }

        public float WinRate
        {
            get
            {
                if (matches == 0)
                {
                    return 0;
                }

                return (float) wins / matches;
            }
        }

        public Player(string name)
        {
            Name = name;
            highScore = 0;
            matches = 0;
            wins = 0;
        }

        public void PlayGame(bool win)
        {
            matches++;
            if (win)
            {
                wins++;
            }
        }
    }
}
