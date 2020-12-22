using System;

/// <summary>Shape class.</summary>
class Shape
{
    /// <summary>Prints a not implemented error.</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}