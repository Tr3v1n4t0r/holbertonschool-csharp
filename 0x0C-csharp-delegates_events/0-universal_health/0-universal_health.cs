using System;

/// <summary>Class containing Player details and functions.</summary>
public class Player
{
    /// <summary>The player name.</summary>
    private string name { get; set; }

    private float _maxHP;
    /// <summary>The maximum player health.</summary>
    private float maxHP
    {
        get { return _maxHP; }
        set
        {
            if (value < 0f)
            {
                Console.WriteLine("maxHP must be greater than 0. maxHP set to 100f by default.");
                _maxHP = 100f;
            }
            else
            {
                _maxHP = value;
            }
        }
    }

    /// <summary>The current player health.</summary>
    private float hp { get; set; }

    /// <summary>Player constructor.</summary>
    /// <param name="name">The player name, "Player" by default.</param>
    /// <param name="maxHP">The maximum player health, 100 by default.</param>
    public Player(string name, float maxHp)
    {
        this.name = name;
        this.maxHP = maxHP;
        this.hp = maxHP;
    }

    /// <summary>Print out the player's health.</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHP} health");
    }
}