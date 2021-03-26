using System;

/// <summary>Modifier names for Players.</summary>
public enum Modifier
{
    /// <summary>Decreases the value.</summary>
    Weak,
    /// <summary>Makes no modification to the value.</summary>
    Base,
    /// <summary>Increases the value.</summary>
    Strong
}

/// <summary>Calculates a new value based on modifier.</summary>
/// <param name="baseValue">The value to modify.</param>
/// <param name="modifier">The modifier to apply to baseValue.</param>
/// <returns>The result of the modification.</returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>A delegate for methods which deal with health.</summary>
/// <param name="v">The value to be affected.</param>
public delegate void CalculateHealth(float v);

/// <summary>Provides current HP arguments.</summary>
public class CurrentHPArgs: EventArgs
{
    /// <summary>Current Health.</summary>
    public readonly float currentHp;

    /// <summary>The CurrentHPArgs constructor.</summary>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}

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

    private string status;
    
    EventHandler<CurrentHPArgs> HPCheck;

    /// <summary>Player constructor.</summary>
    /// <param name="name">The player name, "Player" by default.</param>
    /// <param name="maxHp">The maximum player health, 100 by default.</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        this.maxHp = maxHp;
        this.hp = this.maxHp;
        this.status = $"{this.name} is ready to go!";
        HPCheck += CheckStatus;
    }

    /// <summary>Print out the player's health.</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

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

    /// <summary>Gets a new value based on the original baseValue as affected by modifier.</summary>
    /// <param name="baseValue">The value to be modified.</param>
    /// <param name="modifier">The modifier to apply.</param>
    /// <returns>The new, modified value.</returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        switch (modifier)
        {
            case Modifier.Weak:
                return baseValue / 2f;
            case Modifier.Base:
                return baseValue;
            case Modifier.Strong:
                return baseValue * 1.5f;
            default:
                return baseValue;
        }
    }

    /// <summary>Checks the Player's status.</summary>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == this.maxHp)
            this.status = $"{this.name} is in perfect health!";
        else if (e.currentHp >= (this.maxHp / 2))
            this.status = $"{this.name} is doing well!";
        else if (e.currentHp >= (this.maxHp / 4))
            this.status = $"{this.name} isn't doing too great...";
        else if (e.currentHp > 0)
            this.status = $"{this.name} needs help!";
        else
            this.status = $"{this.name} is knocked out!";
        Console.WriteLine(this.status);
    }
}