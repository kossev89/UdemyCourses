using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(null)]
        [TestCase(new int[]{-1,1})]
        [TestCase(new int[] { 1, 4 })]
        [TestCase(new int[] { 4, 1 })]
        [TestCase(new int[] { 4, -1 })]
        public void IsValidPositionIfPositionNotValid(int[] position)
        {
            int rows = 4;
            int cols = 4;
            int[,] arr = new int[rows, cols];

        }
    }
}