using System;

/// <summary>Class to contain methods for objects.</summary>
class Obj
{
    /// <summary>Checks of a class is a subclass of another class.</summary>
    /// <param name="derivedType">The type to check if subclass.</param>
    /// <param name="baseType">The type to check against.</param>
    /// <returns>True if subclass, else false.</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return (derivedType.IsSubclassOf(baseType));
    }
}