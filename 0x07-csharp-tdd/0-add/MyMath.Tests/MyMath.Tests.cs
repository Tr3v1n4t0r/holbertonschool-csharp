using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1, 0)]
        [TestCase(2, 6)]
        [TestCase(-6, -8)]
        [TestCase(-14, 11)]
        [TestCase(0, 0)]
        public void Test1()
        {
            int result = MyMath.Operations.Add(a, b);
            Assert.AreEqual(result, a + b);
        }
    }
}