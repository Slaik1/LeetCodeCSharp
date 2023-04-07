using LeetCodeCsharp;
namespace LeetCodeCsharpTests
{
    public class TwoSumTests
    {
        public TwoSumSolution Solution { get; set; }
        public TwoSumTests() { Solution = new TwoSumSolution(); }

        [Test]
        public void Test1()
        {
            Assert.That(Solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9), Is.EqualTo(new int[] { 0, 1 }));
        }

        [Test]
        public void Test2()
        {
            Assert.That(Solution.TwoSum(new int[] { 3, 2, 4 }, 6), Is.EqualTo(new int[] { 1, 2 }));
        }

        [Test]
        public void Test3()
        {
            Assert.That(Solution.TwoSum(new int[] { 3, 3 }, 6), Is.EqualTo(new int[] { 0, 1 }));
        }
    }
}