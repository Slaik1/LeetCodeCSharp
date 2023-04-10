using LeetCodeCSharp;

namespace LeetCodeCsharpTests
{
    public class ConcatenationOfArrayTests
    {
        public ConcatenationOfArraySolution Solution { get; set; }

        public ConcatenationOfArrayTests() { Solution = new ConcatenationOfArraySolution(); }

        [Test]
        public void NotEmptyArray()
        {
            Assert.That(Solution.GetConcatenation(new int[] { 1, 2, 1 }), Is.EqualTo(new int[] { 1, 2, 1, 1, 2, 1 }));
            Assert.That(Solution.GetConcatenation(new int[] { 1, 3, 2, 1 }), Is.EqualTo(new int[] { 1, 3, 2, 1, 1, 3, 2, 1 }));
        }

        [Test]
        public void EmptyArray()
        {
            Assert.That(Solution.GetConcatenation(new int[0]), Is.EqualTo(new int[0] ));
        }
    }
}
