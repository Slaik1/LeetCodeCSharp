using LeetCodeCSharp;

namespace LeetCodeCsharpTests
{
    public class FindDisappearedNumbersTests
    {
        public FindDisappearedNumbersSolution Solution { get; set; }

        public FindDisappearedNumbersTests() { Solution = new FindDisappearedNumbersSolution(); }

        [Test]
        public void PositiveNumbers()
        {
            Assert.That(Solution.FindDisappearedNumbers(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 }), Is.EqualTo(new int[] { 5, 6 }));
            Assert.That(Solution.FindDisappearedNumbers(new int[] { 1, 1 }), Is.EqualTo(new int[] { 2 }));
        }
    }
}
