using LeetCodeCSharp;

namespace LeetCodeCsharpTests
{
    public class PalindromeNumberTests
    {
        public PalindromeNumberSolution Solution { get; set; }

        public PalindromeNumberTests() { Solution = new PalindromeNumberSolution(); }

        [Test]
        public void PositiveNumber() 
        { 
            Assert.That(Solution.IsPalindrome(121), Is.EqualTo(true));
            Assert.That(Solution.IsPalindrome(10), Is.EqualTo(false));
        } 

        [Test]
        public void NegativeNumber() => Assert.That(Solution.IsPalindrome(-121), Is.EqualTo(false));
    }
}
