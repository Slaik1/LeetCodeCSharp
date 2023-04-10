using LeetCodeCSharp;

namespace LeetCodeCsharpTests
{
    public class ClimbingStairsTests
    {
        public ClimbingStairsSolution Solution { get; set; }

        public ClimbingStairsTests() { Solution = new ClimbingStairsSolution(); }

        [Test]
        public void PositiveNumber() => Assert.That(Solution.ClimbStairs(3), Is.EqualTo(3));

        [Test]
        public void BigPositiveNumber() => Assert.That(Solution.ClimbStairs(3), Is.EqualTo(3));

        [Test]
        public void NegativeNumber() => Assert.That(Solution.ClimbStairs(39), Is.EqualTo(102334155));
    }
}
