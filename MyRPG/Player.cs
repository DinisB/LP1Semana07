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

        public int Level
        {
            get
            {
                return (int) 1 + xp / 1000;
            }
        }

        public float MaxHealth
        {
            get
            {
                return (float) 100 + (Level - 1) * 20;
            }
        }

        public float Health
        {
            get {
                return Math.Clamp(health, 0, MaxHealth);
            }
        }
    }
}