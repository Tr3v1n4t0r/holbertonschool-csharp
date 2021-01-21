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

    /// <summary>Calculates the inverse of a 2D matrix.</summary>
    /// <param name="matrix">The matrix to calculate.</param>
    /// <returns>The inverted matrix.</returns>
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix.Rank != 2 || matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[1, 1] { {-1} };

        double det = Determinant(matrix);
        if (det == 0 || det == -1)
            return new double[1, 1] { {-1} };

        double detInvert = 1 / det;

        return MultiplyScalar(new double[,] {
            { matrix[1, 1], -matrix[0, 1] },
            { -matrix[1, 0], matrix[0, 0] }
        }, detInvert);
    }
}