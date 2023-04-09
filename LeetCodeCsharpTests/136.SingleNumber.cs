using LeetCodeCSharp;

namespace LeetCodeCsharpTests
{
    public class SingleNumberTests
    {
        public SingleNumberSolution Solution { get; set; }

        public SingleNumberTests() { Solution = new SingleNumberSolution(); }

        [Test]
        public void PositiveNumbers() => Assert.That(Solution.SingleNumber(new int[] { 4, 1, 2, 1, 2 }), Is.EqualTo(4));

        [Test]
        public void LengthEualsOne() => Assert.That(Solution.SingleNumber(new int[] {1 }), Is.EqualTo(1));
    }
}