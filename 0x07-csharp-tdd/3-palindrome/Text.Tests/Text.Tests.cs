using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("abcba")]
        [TestCase("racecar")]
        [TestCase("Mom")]
        [TestCase("a a a    a a   a")]
        [TestCase("A man, a plan, a canal: Panama.")]
        [TestCase("Trevorovert")]
        [TestCase("")]
        public void Returns_True(string input)
        {
            bool result = Text.Str.IsPalindrome(input);
            Assert.IsTrue(result);
        }

        [TestCase("Trevor")]
        [TestCase("hello world")]
        [TestCase("racercar")]
        public void Returns_False(string input)
        {
            bool result = Text.Str.IsPalindrome(input);
            Assert.IsTrue(result);
        }
    }
}