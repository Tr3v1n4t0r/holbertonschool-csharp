using System;
using System.Linq;

/// <summary>Contains methods for vector math.</summary>
class VectorMath
{
    /// <summary>Multiplies a vector by a scalar.</summary>
    /// <param name="vector">A Vector 2 or 3 represented as an array of doubles.</param>
    /// <param name="scalar">The scalar to multiply the vector by.</param>
    /// <returns>The new vector.</returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length < 2 || vector.Length > 3)
            return new double[1] {-1};
        
        double[] total = new double[vector.Length];

        for (uint i = 0; i < vector.Length; i++)
            total[i] = vector[i] * scalar;
        
        return total;
    }
}
