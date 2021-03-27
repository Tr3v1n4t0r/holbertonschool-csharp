using System;

/// <summary>A base class for all game objects.</summary>
abstract class Base
{
    public string name { get; set; }

    public override string ToString()
    {
        return $"{name} is a {this.GetType().Name}";
    }
}

/// <summary>Defines the properties of an interactive object.</summary>
interface IInteractive
{
    void Interact();
}

/// <summary>Defines the properties of breakable objects.</summary>
interface IBreakable
{
    int durability { get; set; }
    void Break();
}

/// <summary>Defines the properties of collectable objects.</summary>
interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

/// <summary>A door class to define doors.</summary>
class Door: Base, IInteractive
{
    /// <summary>Constructor for a Door.</summary>
    /// <param name="name">Name of door, defaulted to "Door"</param>
    public Door(string name = "Door")
    {
        this.name = name;
    }

    /// <summary>Output of interacting with a door.</summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {this.name}. It's locked.");
    }
}