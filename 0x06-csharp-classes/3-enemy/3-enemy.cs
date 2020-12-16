using System;

namespace Enemies
{
    /// <summary>A zombie class.</summary>
    public class Zombie
    {
        /// <summary>Zombie health.</summary>
        public int health;
        /// <summary>Zombie Constructor.</summary>
        public Zombie()
        {
            this.health = 0;
        }
        /// <summary>Zombie Constructor.</summary>
        /// <param name="value">Health</param>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            this.health = value;
        }
        /// <summary>Gets Zombie health.</summary>
        /// <returns>Zombie health</returns>
        public int GetHealth()
        {
            return this.health;
        }
    }
}