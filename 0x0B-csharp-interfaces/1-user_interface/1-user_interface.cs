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

/// <summary>A test object for inheriting interfaces.</summary>
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; }
    public bool isCollected { get; set; }

    public void Interact()
    {

    }

    public void Break()
    {

    }

    public void Collect()
    {

    }
}