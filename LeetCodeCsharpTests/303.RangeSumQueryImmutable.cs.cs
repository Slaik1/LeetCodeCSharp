using LeetCodeCSharp;

namespace LeetCodeCsharpTests
{
    public class RangeSumQueryTests
    {
        public static RangeSumQuerySolution Solution { get; set; }

        public RangeSumQueryTests() { Solution = new RangeSumQuerySolution(new int[0] ); }

        [Test]
        public void IntAnswer()
        {
            setSolution(new int[] { -2, 0, 3, -5, 2, -1 });
            Assert.That(Solution.SumRange(0,2), Is.EqualTo(1));
            Assert.That(Solution.SumRange(2, 5), Is.EqualTo(-1));
            Assert.That(Solution.SumRange(0, 5), Is.EqualTo(-3));
        }

        Action<int[]> setSolution = (int[] nums) => Solution.nums= nums;
    }
}