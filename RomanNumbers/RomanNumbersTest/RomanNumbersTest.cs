using FluentAssertions;
using RomanNumbers;
namespace RomanNumbersTest
{
    public class Tests
    {

        private RomanNumbers.RomanNumbers converter;

        [SetUp]
        public void Setup()
        {
            converter = new RomanNumbers.RomanNumbers();
        }

        [TestCase(7000)]
        [TestCase(4000)]
        [TestCase(8000)]
        [Test]
        public void Amount_Should_Not_Be_More_Than_4000(int number)
        {
            var result = converter.Convert(number);
            result.Should().Be("Invalid number");
        }
    }
}