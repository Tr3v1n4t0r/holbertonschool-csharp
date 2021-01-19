using System;

/// <summary>Contains methods for matrix math.</summary>
class MatrixMath
{
    /// <summary>Rotates a matrix.</summary>
    /// <param name="matrix">A matrix to rotate.</param>
    /// <param name="angle">The angle to rotate by.</param>
    /// <returns>The new, rotated matrix.</returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix.Rank != 2 || matrix.GetLength(1) != 2)
            return new double[1,1] { {-1} };

        double sin = Math.Sin(angle);
        double cos = Math.Cos(angle);

        double[,] rot = new double[matrix.GetLength(0), 2];

        for (uint i = 0; i < matrix.GetLength(0); i++)
        {
            rot[i, 0] = Math.Round(matrix[i, 0] * cos - matrix[i, 1] * sin, 2);
            rot[i, 1] = Math.Round(matrix[i, 0] * sin + matrix[i, 1] * cos, 2);
        }

        return rot;
    }
}
