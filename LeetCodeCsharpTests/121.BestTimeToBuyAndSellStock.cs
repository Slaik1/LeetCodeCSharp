using LeetCodeCSharp;

namespace LeetCodeCsharpTests
{
    public class BestTimeToBuyAndSellStockTests
    {
        public BestTimeToBuyAndSellStockSolution Solution { get; set; }

        public BestTimeToBuyAndSellStockTests() { Solution = new BestTimeToBuyAndSellStockSolution(); }

        [Test]
        public void HasProfit() => Assert.That(Solution.MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 }), Is.EqualTo(5));

        [Test]
        public void HasNoProfit() => Assert.That(Solution.MaxProfit(new int[] { 7, 6, 4, 3, 1 }), Is.EqualTo(0));
    }
}