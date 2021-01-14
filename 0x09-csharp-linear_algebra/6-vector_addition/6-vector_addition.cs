using System;
using System.Linq;

/// <summary>Contains methods for vector math.</summary>
class VectorMath
{
    /// <summary>Adds 2 Vector2 or Vector3 vectors.</summary>
    /// <param name="vector1">1st vector</param>
    /// <param name="vector2">2nd vector</param>
    /// <returns>The sum of the vector.</returns>
    public static double Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length != vector2.Length || vector1.Length < 3 || vector1.Length > 3)
            return new double[1] {-1};
        
        double[] sum = new double[vector1.Length];
        for (uint i = 0; i < vector1.Length; i++)
            sum[i] = vector1[i] + vector2[i];

        return sum;
    }
}