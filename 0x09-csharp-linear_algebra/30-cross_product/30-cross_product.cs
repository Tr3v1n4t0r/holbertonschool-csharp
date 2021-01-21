using System;

/// <summary>Contains methods for vector math.</summary>
class VectorMath
{
    /// <summary>Calculates the cross product of 2 Vector3 vectors.</summary>
    /// <param name="vector1">1st vector</param>
    /// <param name="vector2">2nd vector</param>
    /// <returns>The cross product of the vector.</returns>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != 3 || vector2.Length != 3)
            return new double[1] { -1 };
        
        return new double[3] {
            vector1[1] * vector2[2] - vector1[2] * vector2[1],
            vector1[2] * vector2[0] - vector1[0] * vector2[2],
            vector1[0] * vector2[1] - vector1[1] * vector2[0]
        };
    }
}