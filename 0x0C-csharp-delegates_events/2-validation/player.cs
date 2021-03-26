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
    public Player(string name = "Player", float maxHp = 100f)
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

    /// <summary>A delegate for methods which deal with health.</summary>
    /// <param name="v">The value to be affected by.</param>
    private delegate void CalculateHealth(float v);

    /// <summary>Reduce the health of the player.</summary>
    /// <param name="damage">The amount to reduce the health by.</param>
    public void TakeDamage(float damage)
    {
        damage = Math.Max(damage, 0);
        ValidateHP(this.hp - damage);
        Console.WriteLine($"{name} takes {damage} damage!");
    }

    /// <summary>Increase the health of the player.</summary>
    /// <param name="heal">The amount to increase the health by.</param>
    public void HealDamage(float heal)
    {
        heal = Math.Max(heal, 0);
        ValidateHP(this.hp + heal);
        Console.WriteLine($"{name} heals {heal} HP!");
    }

    /// <summary>Validates that the requested new health of the player is between 0 and maxHp.</summary>
    /// <param name="newHp">The new hp of the player.</param>
    public void ValidateHP(float newHp)
    {
        this.hp = Math.Max(0, Math.Min(this.maxHp, newHp));
    }
}