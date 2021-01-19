using System;

/// <summary>Contains methods for matrix math.</summary>
class MatrixMath
{
    /// <summary>Multiplies 2 matrices.</summary>
    /// <param name="matrix1">A matrix to multiply.</param>
    /// <param name="matrix2">A matrix to multiply.</param>
    /// <returns>The product of matrix multiplication.</returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.Rank != 2 || matrix2.Rank != 2 ||
            matrix1.GetLength(1) != matrix2.GetLength(0) ||
            return new double[1,1] { {-1} };

        double[,] product = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

        for (uint i = 0; i < product.GetLength(0); i++)
        {
            for (uint j = 0; j < product.GetLength(1); j++)
            {
                double sum = 0;

                for (uint k = 0; k < matrix2.GetLength(0); k++)
                    sum += matrix1[i, k] * matrix2[k, j];

                product[i, j] = sum;
            }
        }

        return product;
    }
}
