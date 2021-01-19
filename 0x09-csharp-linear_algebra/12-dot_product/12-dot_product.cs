using System;

/// <summary>Contains methods for vector math.</summary>
class VectorMath
{
    /// <summary>Gets the dot product of 2 Vector2 or Vector3.</summary>
    /// <param name="vector1">A Vector 2 or 3 represented as an array of doubles</param>
    /// <param name="vector2">A Vector 2 or 3 represented as an array of doubles</param>
    /// <returns>The dot product of the vectors.</returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != vector2.Length || vector1.Length < 2 || vector2.Length > 3)
            return -1;

        double total = 0;

        for (uint i = 0; i < vector1.Length; i++)
            total += vector1[i] * vector2[i];

        return total;
    }
}
