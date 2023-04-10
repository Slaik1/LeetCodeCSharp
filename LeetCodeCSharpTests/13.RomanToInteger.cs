using LeetCodeCSharp;

namespace LeetCodeCsharpTests
{
    public class RomanToIntegerTests
    {
        public RomanToIntegerSolution Solution { get; set; }

        public RomanToIntegerTests() { Solution = new RomanToIntegerSolution(); }

        [Test]
        public void NotCompositeNumber()
        {
            Assert.That(Solution.RomanToInt("III"), Is.EqualTo(3));
            Assert.That(Solution.RomanToInt("LVIII"), Is.EqualTo(58));
        }

        [Test]
        public void CompositeNumber() => Assert.That(Solution.RomanToInt("MCMXCIV"), Is.EqualTo(1994));
    }
}
