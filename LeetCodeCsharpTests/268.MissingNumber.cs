using LeetCodeCSharp;

namespace LeetCodeCsharpTests
{
    public class MissingNumberTests
    {
        public MissingNumberSolution Solution { get; set; }

        public MissingNumberTests() { Solution = new MissingNumberSolution(); }

        [Test]
        public void PositiveNumbers()
        {
            Assert.That(Solution.MissingNumber(new int[] { 3, 0, 1 }), Is.EqualTo(2));
            Assert.That(Solution.MissingNumber(new int[] { 0, 1 }), Is.EqualTo(2));
            Assert.That(Solution.MissingNumber(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }), Is.EqualTo(8));
        }
    }
}