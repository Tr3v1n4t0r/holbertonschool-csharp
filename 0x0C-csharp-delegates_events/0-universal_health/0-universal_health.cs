using System;

/// <summary>Class containing Player details and functions.</summary>
public class Player
{
    /// <summary>The player name.</summary>
    private string name { get; set; }

    private float _maxHp;
    /// <summary>The maximum player health.</summary>
    private float maxHp
    {
        get { return _maxHp; }
        set
        {
            if (value < 0f)
            {
                Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
                _maxHp = 100f;
            }
            else
            {
                _maxHp = value;
            }
        }
    }

    /// <summary>The current player health.</summary>
    private float hp { get; set; }

    /// <summary>Player constructor.</summary>
    /// <param name="name">The player name, "Player" by default.</param>
    /// <param name="maxHp">The maximum player health, 100 by default.</param>
    public Player(string name = Player, float maxHp = 100)
    {
        this.name = name;
        this.maxHp = maxHp;
        this.hp = this.maxHp;
    }

    /// <summary>Print out the player's health.</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}