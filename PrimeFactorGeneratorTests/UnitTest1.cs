using System.Linq;
using Xunit;
using kata2_PrimeFactors;

namespace PrimeFactorGeneratorTests
{
    //https://github.com/ardalis/kata-catalog/blob/master/katas/Prime%20Factors.md
    public class UnitTest1
    {
        [Theory]
        [InlineData(new[] {1}, 1)]
        [InlineData(new[] {3}, 3)]
        [InlineData(new[] {7}, 7)]
        public void OneNumberProvided(int[] expected, int input)
        {
            var result = Program.Generate(input);
            Assert.Equal(expected.ToList(), result);
        }

        [Theory]
        [InlineData(new int[] {}, -1)]
        public void NegativeOrZeroNumberProvided(int[] expected, int input)
        {
            var result = Program.Generate(input);
            Assert.Equal(expected.ToList(), result);
        }

        [Theory]
        [InlineData(new[] { 2, 2 }, 4)]
        [InlineData(new[] { 2, 2, 3 }, 12)]
        [InlineData(new[] {13}, 13)]
        private void ValidNumberAdded(int[] expected, int input)
        {
            var result = Program.Generate(input);
            Assert.Equal(expected.ToList(), result);
        }

    }
}
