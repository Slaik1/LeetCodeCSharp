using LeetCodeCSharp;

namespace LeetCodeCsharpTests
{
    public class ContainsDuplicateTests
    {
        public ContainsDuplicateSolution Solution { get; set; }
        public ContainsDuplicateTests() { Solution = new ContainsDuplicateSolution(); }

        [Test]
        public void PositiveNumbers()
        {
            Assert.That(Solution.ContainsDuplicate(new int[] { 1, 2, 3, 1 }), Is.EqualTo(true));
            Assert.That(Solution.ContainsDuplicate(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }), Is.EqualTo(true));
            Assert.That(Solution.ContainsDuplicate(new int[] { 1, 2, 3, 4 }), Is.EqualTo(false));
        }

        [Test]
        public void NegativeNumbers()
        {
            Assert.That(Solution.ContainsDuplicate(new int[] { -1, 2, 3, 1 }), Is.EqualTo(false));
            Assert.That(Solution.ContainsDuplicate(new int[] { 1, 2, -3, 4,-3 }), Is.EqualTo(true));
        }
    }
}