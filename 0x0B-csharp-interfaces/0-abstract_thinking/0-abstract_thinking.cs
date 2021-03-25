using System;

/// <summary>A base class for all game objects.</summary>
abstract class Base
{
    public string name { get; set; }

    public override string ToString()
    {
        return $"{name} is a {this.GetType(). Name}";
    }
}