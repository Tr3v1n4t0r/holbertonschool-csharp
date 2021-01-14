using System;
using System.Linq;

/// <summary>Contains methods for vector math.</summary>
class VectorMath
{
    /// <summary>Gets the magnitude of a Vector2 or Vector3.</summary>
    /// <param name="vector">A Vector 2 or 3 represented as an array of doubles</param>
    /// <returns>The magnitude of the vector.</returns>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length != 2 && vector.Length != 3)
            return -1;

        double product = (from num in vector select num * num).Sum();
        return Math.Round(Math.Sqrt(product), 2);
    }
}