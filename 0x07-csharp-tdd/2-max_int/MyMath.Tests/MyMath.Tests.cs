using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Positive()
        {
            List<int> input = new List<int> {1, 2, 3, 4};
            int output = MyMath.Operations.Max(input);
            Assert.AreEqual(4, output);
        }

        [Test]
        public void Negative()
        {
            List<int> input = new List<int> {-1, -2, -3, -4};
            int output = MyMath.Operations.Max(input);
            Assert.AreEqual(-1, output);
        }

        [Test]
        public void Empty()
        {
            List<int> input = new List<int>();
            int output = MyMath.Operations.Max(input);
            Assert.AreEqual(0, output);
        }

        [Test]
        public void Null()
        {
            List<int> input = null;
            int output = MyMath.Operations.Max(input);
            Assert.AreEqual(0, output);
        }
    }
}