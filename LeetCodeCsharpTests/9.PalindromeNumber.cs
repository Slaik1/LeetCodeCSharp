using LeetCodeCsharp;
using LeetCodeCSharp;

namespace LeetCodeCsharpTests
{
    public class PalindromeNumberTests
    {
        public PalindromeNumberSolution Solution { get; set; }

        public PalindromeNumberTests() { Solution = new PalindromeNumberSolution(); }

        [Test]
        public void Test1()
        {
            Assert.That(Solution.IsPalindrome(121), Is.EqualTo(true));
        }

        [Test]
        public void Test2()
        {
            Assert.That(Solution.IsPalindrome(-121), Is.EqualTo(false));
        }

        [Test]
        public void Test3()
        {
            Assert.That(Solution.IsPalindrome(10), Is.EqualTo(false));
        }
    }
}