using System;

namespace MyMath
{
    /// <summary>Class for matrix math functions.</summary>
    public class Matrix
    {
        /// <summary>Divides each element in a matrix by a given number.</number>
        /// <param name="matrix">A matrix of integers.</param>
        /// <param name="num">The number to divide the matrix elements by.</param>
        /// <returns>A new matrix with the results.</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
            if (matrix == null)
                return null;
            
            int[,] newMatrix = (int[,])matrix.Clone();
            for (int i = 0; i < newMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < newMatrix.GetLength(1); j++)
                    newMatrix[i, j] /= num;
            }
            return newMatrix;
        }
    }
}
