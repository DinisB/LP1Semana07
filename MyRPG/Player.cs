using System;

namespace MyRPG
{
    class Player
    {
        private int xp;
        private float health;
        public string Name { get; }

        public int XP{
            get => xp;
            set
            {
                if (value > 0)
                {
                    xp += value;
                }
            }
        }
    }
}