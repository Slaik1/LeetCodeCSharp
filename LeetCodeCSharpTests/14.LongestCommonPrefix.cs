using LeetCodeCSharp;

namespace LeetCodeCsharpTests
{
    public class LongestCommonPrefixTests
    {
        public LongestCommonPrefixSolution Solution { get; set; }

        public LongestCommonPrefixTests() { Solution = new LongestCommonPrefixSolution(); }

        [Test]
        public void ContainsPrefix()=>Assert.That(Solution.LongestCommonPrefix(new string[] { "flower", "flow", "flight" }), Is.EqualTo("fl"));

        [Test]
        public void DoNotContainsPrefix() => Assert.That(Solution.LongestCommonPrefix(new string[] { "dog", "racecar", "car" }), Is.EqualTo(""));
    }
}
