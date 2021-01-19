using System;

/// <summary>Contains methods for matrix math.</summary>
class MatrixMath
{
    /// <summary>Multiplies a matrix by a scalar.</summary>
    /// <param name="matrix">A matrix to multiply</param>
    /// <param name="scalar">The scalar to multiply the matrix by.</param>
    /// <returns>The product of matrix scalar multiplication.</returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if (matrix.Rank != 2 || matrix.GetLength(0) != matrix.GetLength(1) ||
            matrix.GetLength(0) < 2 || matrix.GetLength(0) > 3)
            return new double[1,1] { {-1} };

        double[,] product = new double[matrix.GetLength(0), matrix.GetLength(1)];

        for (uint i = 0; i < matrix.GetLength(0); i++)
        {
            for (uint j = 0; j < matrix.GetLength(1); j++)
                product[i, j] = matrix[i, j] * scalar;
        }

        return product;
    }
}
