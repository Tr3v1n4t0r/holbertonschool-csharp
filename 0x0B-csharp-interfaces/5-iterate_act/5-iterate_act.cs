using System;
using System.Collections.Generic;

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

/// <summary>A class for decoration mechanics.</summary>
class Decoration: Base, IInteractive, IBreakable
{
    public bool isQuestItem { get; set; }
    public int durability { get; set; }

    /// <summary>Constructor for a decoration.</summary>
    /// <param name="name">Decoration name, defaulted to "Decoration".</param>
    /// <param name="durability">Decoration durability, defaulted to 1.</param>
    /// <param name="isQuestItem">Defines if a decoration is a quest item, defaulted to false.</param>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");

        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary>Output of interacting with a decoration.</summary>
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
            return;
        }

        if (isQuestItem)
        {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
            return;
        }

        Console.WriteLine($"You look at the {name}. Not much to see here.");
    }

    /// <summary>Reduce the durability of the decoration.</summary>
    public void Break()
    {
        durability--;

        if (durability > 0)
        {
            Console.WriteLine($"You hit the {name}. It cracks.");
        }
        else if (durability == 0)
        {
            Console.WriteLine($"You smash the {name}. What a mess.");
        }
        else
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}

/// <summary>A key object class.</summary>
class Key: Base, ICollectable
{
    public bool isCollected { get; set; }

    /// <summary>Key constructor.</summary>
    /// <param name="name">The key's name, defaulted to "Key".</param>
    /// <param name="isCollected">Whether or not the key is collected, defaulted to false.</param>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>Collect the key.</summary>
    public void Collect()
    {
        if (isCollected)
            Console.WriteLine($"You have already picked up the {name}.");
        else
        {
            isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }
    }
}

/// <summary>A class that manages all room objects.</summary>
class RoomObjects
{
    /// <summary>Iterates over all the objects in a room and does the related action.</summary>
    /// <param name="roomObjects">A list of Base objects in the room.</param>
    /// <param name="type">Defines what kind of object it is.</param>
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (Base item in roomObjects)
        {
            if (type.IsInstanceOfType(item))
            {
                if (type == typeof(IInteractive))
                    ((IInteractive)item).Interact();
                if (type == typeof(IBreakable))
                    ((IBreakable)item).Break();
                if (type == typeof(ICollectable))
                    ((ICollectable)item).Collect();
            }
        }
    }
}