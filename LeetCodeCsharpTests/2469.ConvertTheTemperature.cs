using LeetCodeCSharp;

namespace LeetCodeCsharpTests
{
    public class ConvertTemperatureTests
    {
        public ConvertTemperatureSolution Solution { get; set; }

        public ConvertTemperatureTests() { Solution = new ConvertTemperatureSolution(); }

        [Test]
        public void PositiveTemperature()
        {
            Assert.That(Solution.ConvertTemperature(36.50), Is.EqualTo(new double[] { 309.65000, 97.70000 }));
            Assert.That(Solution.ConvertTemperature(122.11), Is.EqualTo(new double[] { 395.26000, 251.79800 }));
        }
    }
}