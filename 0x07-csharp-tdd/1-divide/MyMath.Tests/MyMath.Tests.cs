using NUnit.Framework;
using System;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Positive_by_Positive()
        {
            int[,] input = new int[,] {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
            int [,] output = MyMath.Matrix.Divide(input, 2);
            int[,] expected = new int[,] {
                {0, 1, 1},
                {2, 2, 3},
                {3, 4, 5}
            };
            Assert.AreEqual(output, expected);
        }

        [Test]
        public void Positive_by_Zero()
        {
            int[,] input = new int[,] {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
            int [,] output = MyMath.Matrix.Divide(input, 0);
            Assert.IsNull(output);
        }

        [Test]
        public void Null_Matrix()
        {
            int [,] output = MyMath.Matrix.Divide(null, 3);
            Assert.IsNull(output);
        }

        [Test]
        public void Null_by_Zero()
        {
            int [,] output = MyMath.Matrix.Divide(null, 0);
            Assert.IsNull(output);
        }
    }
}