using LeetCodeCSharp;

namespace LeetCodeCsharpTests
{
    public class CountingBitsTests
    {
        public CountingBitsSolution Solution { get; set; }

        public CountingBitsTests() { Solution = new CountingBitsSolution(); }

        [Test]
        public void PositiveNumber()
        {
            Assert.That(Solution.CountBits(2), Is.EqualTo(new int[] { 0, 1, 1 }));
            Assert.That(Solution.CountBits(5), Is.EqualTo(new int[] { 0, 1, 1, 2, 1, 2 }));
        }
    }
}
