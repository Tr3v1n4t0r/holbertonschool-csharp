using System;

/// <summary>Contains methods for matrix math.</summary>
class MatrixMath
{
    /// <summary>Calculates the determinant of a matrix.</summary>
    /// <param name="matrix">The matrix to calculate from.</param>
    /// <returns>The determinant.</returns>
    public static double Determinant(double[,] matrix)
    {
        if (matrix.Rank != 2 || matrix.GetLength(0) != matrix.GetLength(1) ||
            matrix.GetLength(0) < 2 || matrix.GetLength(0) > 3)
            return -1;

        if (matrix.GetLength(0) == 2)
        {
            return Math.Round(matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0], 2);
        }
        else
        {
            double determinant = 0;
            determinant += matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[2, 1] * matrix[1, 2]);
            determinant -= matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[2, 0] * matrix[1, 2]);
            determinant += matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[2, 0] * matrix[1, 1]);
            return Math.Round(determinant, 2);
        }
    }
}