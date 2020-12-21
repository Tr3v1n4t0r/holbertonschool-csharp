using System;

/// <summary>Class to contain methods for objects.</summary>
class Obj
{
    /// <summary>Gets if an object is an instance of Array.</summary>
    /// <param name="obj">The object to check.</param>
    /// <returns>True if an instance, else false.</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return (obj is Array);
    }
}