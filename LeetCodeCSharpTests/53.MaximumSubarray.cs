using LeetCodeCSharp;

namespace LeetCodeCsharpTests
{
    public class MaximumSubarrayTests
    {
        public MaximumSubarraySolution Solution { get; set; }

        public MaximumSubarrayTests() { Solution = new MaximumSubarraySolution(); }

        [Test]
        public void DifferentNumber() => Assert.That(Solution.MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }), Is.EqualTo(6));

        [Test]
        public void LengthEqualsOne() => Assert.That(Solution.MaxSubArray(new int[] { 1 }), Is.EqualTo(1));
    }
}
