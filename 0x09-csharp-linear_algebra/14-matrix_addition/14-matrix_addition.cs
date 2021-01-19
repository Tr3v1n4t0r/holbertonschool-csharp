using System;

/// <summary>Contains methods for matrix math.</summary>
class MatrixMath
{
    /// <summary>Gets the sum of 2 matrices.</summary>
    /// <param name="matrix1">A matrix to add</param>
    /// <param name="matrix2">A matrix to add</param>
    /// <returns>The sum of the matrices.</returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.Rank != 2 || matrix2.Rank != 2 ||
            matrix1.GetLength(0) != matrix2.GetLength(0) ||
            matrix1.GetLength(1) != matrix2.GetLength(1) ||
            matrix1.GetLength(0) != matrix1.GetLength(1) ||
            matrix1.GetLength(0) < 2 || matrix1.GetLength(0) > 3)
            return new double[1,1] { {-1} };

        double[,] sum = new double[matrix1.GetLength(0), matrix1.GetLength(1)];

        for (uint i = 0; i < matrix1.GetLength(0); i++)
        {
            for (uint j = 0; j < matrix1.GetLength(1); j++)
                sum[i, j] = Math.Round(matrix1[i, j] + matrix2[i, j], 2);
        }

        return sum;
    }
}
