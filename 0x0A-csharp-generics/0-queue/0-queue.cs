using System;

/// <summary>A Queue class.</summary>
/// <typeparam name="T">The type contained in the Queue.</typeparam>
class Queue<T>
{
    /// <summary>Get the type that Queue contains.</summary>
    /// <returns>The type in Queue.</returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}