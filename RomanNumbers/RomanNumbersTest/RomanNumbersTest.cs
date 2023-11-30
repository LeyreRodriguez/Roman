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

        [Test]
        public void Should_Return_I_When_1_Is_Passed()
        {
            var result = converter.Convert(1);
            result.Should().Be("I");
        }

        [Test]
        public void Should_Return_II_When_2_Is_Passed()
        {
            var result = converter.Convert(2);
            result.Should().Be("II");
        }



        [Test]
        public void Should_Return_X_When_10Is_Passed()
        {
            var result = converter.Convert(10);
            result.Should().Be("X");
        }

        [Test]
        public void Should_Return_IX_When_9_Is_Passed()
        {
            var result = converter.Convert(9);
            result.Should().Be("IX");
        }


        [Test]
        public void Should_Return_IV_When_4_Is_Passed()
        {
            var result = converter.Convert(4);
            result.Should().Be("IV");
        }


        

    }
}